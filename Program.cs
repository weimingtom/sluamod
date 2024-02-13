/*
 * 由SharpDevelop创建。
 * 用户： a
 * 日期: 2023/10/8
 * 时间: 1:29
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using SLua;

namespace sluamod
{
	class Program
	{
		LuaSvr svr;
	    LuaTable self;
	    LuaFunction update;
	    //[CustomLuaClass]
	    public delegate void UpdateDelegate(object self);
	    
		
		private static LuaSvr l;
		
		public static void Main_(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			l = new LuaSvr();
			l.init(null, () =>{
			       	l.luaState.doString("print('hello')");
			});
			
			//new Program().Start();

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		/*
		void Start () {
	        svr = new LuaSvr();
	        svr.init(null, () => {
	            self = (LuaTable)svr.start("circle/circle");
	            update = (LuaFunction)self["update"] ;
	        });
		}
		
		void Update () {
	    
		}*/
	}
	
	
	
}