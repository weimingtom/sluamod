/*
 * 由SharpDevelop创建。
 * 用户： a
 * 日期: 2023/10/8
 * 时间: 2:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using SLua;

namespace sluamod
{
	/// <summary>
	/// Description of TestSLua.
	/// </summary>
	public class TestSLua
	{
		    private LuaSvr luaSvr;

		    static public void Main() {
		        TestSLua demo = new TestSLua();
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
           		var code = @"
print('hello')
    local TestSLua = Slua.GetClass('sluamod.TestSLua')
    return TestSLua.DoMethod(543210543)
";
            	var ret = luaSvr.luaState.doString(code);
            	Console.WriteLine("ret == " + ret);
		    }
		    
		    //[MethodImpl(MethodImplOptions.NoInlining)]
	        static double DoMethod(int a1)
	        {
	            //Assert.AreEqual(543210543, a1);
	            return a1;
	        }
	}
}
