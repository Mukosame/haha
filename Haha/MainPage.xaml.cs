using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Haha
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        String word = null;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }



        private void OKClick(object sender, RoutedEventArgs e)
        {
            word = null;//clear
            
            if ( dxs.Text != "")
            {
                word += xgj.Text + "：" + jzx.Text + "，你觉得" + dxs.Text + "好不好呀？\n";
                word += "\n" + jzx.Text + "：吼啊！\n";
            }

            if (zy.Text != "")
            {
                word += "\n" + xgj.Text + "：" + zy.Text + "也支持吗？\n";
                word += "\n" + jzx.Text + "：当然啦！\n";
            }

            if (nmn.Text != "")
            {
                word += "\n" + xgj.Text + "：那么早就说要连任，会不会给人感觉是" + nmn.Text + "呀？\n";
                word += "\n" + jzx.Text + "：";
            }
            if (xgd.Text != "")
            {
                word += "任何事，也要按照" + xgd.Text + "，";
            }
            if (azx.Text !="")
            {
                word += "按照" + azx.Text + "来进行。";
            }
            word += "刚才你问我，我可以回答一句「无可奉告」，但是你们又不高兴，我怎么办？";
            if (qd.Text != "")
            {
                word += "我讲的意思不是要" + qd.Text + "。";
            }
            word += "你问我支持不支持，我说支持。我就明确告诉你这一点。我感觉你们新闻界还需要学习，你们毕竟还是 too young ，你明白这意思吧？我告诉你们我是身经百战了，见得多了。";
            if (xf.Text != "")
            {
                word += xf.Text ;
            }
            if (gj.Text != "")
            {
                word += "哪一个" + gj.Text;
            }
            if (q.Text != "")
            {
                word += "我没有" + q.Text + "过？";
            }
            word += "你们要知道，";
            if (mg.Text != "")
            {
                word += mg.Text + "的";
            }
            if (hls.Text != "")
            {
                word += hls.Text;
            }
            word += "，比你们不知道要高到哪里去了，我跟他谈笑风生。所以说媒体还是要提高自己的知识水平，识得唔识得啊？我为你们感到拙计呀……";
            if (xfj.Text != "")
            {
                word += "你们有一个好，全世界跑到什么地方，你们比" + xfj.Text + "跑得还快，";
            }
            word += "但是问来问去的问题呀，都 too simple ， sometimes naive ！懂了没有？\n";
            if (dxs.Text !="")
            {
                word += "\n" + xgj.Text + "：可是能不能说一下为什么支持" + dxs.Text + "？\n";
            }
            word += "\n" + jzx.Text + "：我很抱歉，";
            if (zz.Text != "")
            {
                word += "我今天是作为一个" + zz.Text + "跟你们讲，";
            }
            word += "我不是新闻工作者，但是我见得太多了。我有必要告诉你们一些人生的经验……中国有一句话叫「闷声发大财」，我就什么话也不说，这是最好的。但是我想我见到你们这样热情，一句话不说也不好。在宣传上将来如果你们报道上有偏差，你们要负责任。";
            if (nmn.Text !="")
            {
                word += "我没有说要" + nmn.Text + "，没有任何这个意思，";
            }
            if (dxs2.Text != "")
            {
                word += "但你们一定要问我对" + dxs2.Text + "支持不支持，";
            }
            if (ts.Text != "")
            {
                word += "他现在是" + ts.Text + "，我们怎么能不支持" + ts.Text + "？\n";
            }
            if (lr.Text!="")
            {
                word += "\n" + xgj.Text + "：但是如果说" + lr.Text + "呢？\n";
            }
            word += "\n" + jzx.Text + "：";
            if (xgdfl.Text != "")
            {
                word += lr.Text + "也得按照" + xgdfl.Text + "，";
            }
            word += "对不对？当然我们的也是很重要的。到那时候我们会表态的。明白这意思吗？你们不要想喜欢弄个大新闻，";
            if (qd.Text != "")
            {
                word += "说我们已经" + qd.Text + "了，";
            }
            word += "把我批判一番，你们啊，naive！ I'm angry！你们这样子是不行的！我今天算是得罪了你们一下。";

                //this.NavigationService.Navigate(new Uri("/Info_Page.xaml", UriKind.Relative));

            Frame.Navigate(typeof(PageOK), word);
        }

    }
}
