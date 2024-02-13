/*
 * 由SharpDevelop创建。
 * 用户： a
 * 日期: 2023/10/8
 * 时间: 1:59
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using SLua;

namespace sluamod
{
	/// <summary>
	/// Description of Demo.
	/// </summary>
	public class Demo
	{
		    private LuaSvr luaSvr;

		    static public void Main__() {
		        Demo demo = new Demo();
		        demo.Init();   
		        Console.ReadKey(true);
		    }
		        
		    public void Init()
		    {
		        luaSvr = new LuaSvr();
		        luaSvr.init(null,onComplete);
		    }
		    void onComplete() {
		        Console.WriteLine("complete");
		        string txt=@"
		        local a=1
		        local b=2
		        print('result',a+b)
		        ";
		        luaSvr.luaState.doString(txt);
		    }
	}
}
