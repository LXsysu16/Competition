﻿using System;
using System.Diagnostics;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using ExcelDataReader;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Competition.Models;
using Competition.ViewModels;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Competition.Views
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    sealed partial class Match : Page
    {
        private Boolean TennisFlag = false;
        private Boolean BadmintonFlag = false;
        private Boolean PingPangFlag = false;
        public MatchesVM matchesVM = MatchesVM.GetMatchesVM();
        public Match()
        {
            this.InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        private async void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            StorageFile file = await SelectFile();
            if (file == null)
            {
                Debug.WriteLine("[Info] File is null");
                return;
            }
            Stream fileStream = (await file.OpenStreamForReadAsync()) as Stream;
            
            IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
            DataSet dataSet = excelDataReader.AsDataSet();
            Debug.WriteLine(dataSet.GetXml());
        }

        private async void Border_Drop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("[Info] Drag");
            if (e.DataView.Contains(StandardDataFormats.StorageItems))
            {
                Debug.WriteLine("[Info] DataView Contains StorageItems");
                var items = await e.DataView.GetStorageItemsAsync();
                items = items.OfType<StorageFile>().Where(s => s.FileType.Equals(".xlsx")).ToList() as IReadOnlyList<IStorageItem>;
                if(items!=null && items.Any())
                {
                    await HandleExcel(items);
                }
            }
        }

        private async Task HandleExcel(IReadOnlyList<IStorageItem> items)
        {
            foreach (var item in items)
            {
                Debug.WriteLine(item.Path);
                StorageFile file = item as StorageFile;
                //FileStream fileStream = new FileStream(item.Path, FileMode.Open,FileAccess.Read);
                Stream fileStream = (await file.OpenStreamForReadAsync()) as Stream;
                if (fileStream == null)
                {
                    Debug.WriteLine("[Info] fileStream is null");
                    return;
                }
                IExcelDataReader excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);

                DataSet dataSet = excelDataReader.AsDataSet();
                Debug.WriteLine(dataSet.GetXml());
                excelDataReader.Close();
            }
        }

        private async Task<StorageFile> SelectFile()
        {
            var fop = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.PicturesLibrary
            };
            fop.FileTypeFilter.Add(".xlsx");
            fop.FileTypeFilter.Add(".xls");
            return await fop.PickSingleFileAsync();
        }

        private void Border_DragOver(object sender, DragEventArgs e)
        {
            Debug.WriteLine("[Info] DragOver");

            //设置操作类型
            e.AcceptedOperation = DataPackageOperation.Copy;

            //设置提示文字
            e.DragUIOverride.Caption = "拖拽到此处即可添加文件";

            ////是否显示拖放时的文字 默认为true
            //e.DragUIOverride.IsCaptionVisible = true;

            ////是否显示文件图标，默认为true
            //e.DragUIOverride.IsContentVisible = true;

            ////Caption 前面的图标是否显示。默认为 true
            //e.DragUIOverride.IsGlyphVisible = true;

            ////自定义文件图标，可以设置一个图标
            //e.DragUIOverride.SetContentFromBitmapImage(new BitmapImage(new Uri("ms-appx:///Assets/copy.jpg")));
        }

        private void CreateMatch_Click(object sender, RoutedEventArgs e)
        {
            MatchesExisted.Visibility = Visibility.Visible;
            if (MatchBox.SelectedIndex == 0)
            {
                if (!TennisFlag)
                {
                    MainPage.navMenuItemVMobj.NavMenuSecondaryTennisItem.Add(new NavMenuItem()
                    {
                        symbol = Symbol.World,
                        text = "网球",
                        Selected = Visibility.Collapsed,
                        destPage = typeof(MatchCreated)
                    });
                    matchesVM.AllMatches.Add(new Matches("1","网球", NameBox.Text, DateTimeOffset.Now.ToString()));
                    TennisFlag = true;
                }
                else
                {
                    MatchBoxTips.Visibility = Visibility.Visible;
                    return;
                }
            }
            if (MatchBox.SelectedIndex == 1)
            {
                if (!BadmintonFlag)
                {
                    MainPage.navMenuItemVMobj.NavMenuSecondaryBadmintonItem.Add(new NavMenuItem()
                    {
                        symbol = Symbol.World,
                        text = "羽毛球",
                        Selected = Visibility.Collapsed,
                        destPage = typeof(MatchCreated)
                    });
                    BadmintonFlag = true;
                }
                else
                {
                    MatchBoxTips.Visibility = Visibility.Visible;
                    return;
                }
            }
            if (MatchBox.SelectedIndex == 2)
            {
                if (!PingPangFlag)
                {
                    MainPage.navMenuItemVMobj.NavMenuSecondaryPingPangItem.Add(new NavMenuItem()
                    {
                        symbol = Symbol.World,
                        text = "乒乓球",
                        Selected = Visibility.Collapsed,
                        destPage = typeof(MatchCreated)
                    });
                    PingPangFlag = true;
                }
                else
                {
                    MatchBoxTips.Visibility = Visibility.Visible;
                    return;
                }
            }
            MainPage.Curr.NavMenuSecondaryTennisListView.Visibility = Visibility.Visible;
            MainPage.Curr.NavMenuSecondaryPingPangListView.Visibility = Visibility.Visible;
            MainPage.Curr.NavMenuSecondaryBadmintonListView.Visibility = Visibility.Visible;
        }

        private void DeleteMatch_Click(object sender, RoutedEventArgs e)
        {
            matchesVM.AllMatches.Remove((sender as Button).DataContext as Matches);
        }

    }
}
