# sluamod
My mod of slua v1.1.1, with vs2013 native code debugging  

## Ref  
* (dead) http://www.slua.net/  
* https://github.com/pangweiwei/slua/blob/master/help.md  
* https://github.com/pangweiwei/slua  
* https://github.com/pangweiwei/slua/releases?page=2  
* https://www.nuget.org/packages/slua-standalone  

## History  
* 2024-03-24, port to vs2013  
* 2024-02-13, replace slua-standalone.dll with slua-1.1.1\Assets\Plugins\Slua_Managed csharp code  
* 2023-10-08, first sharpdevelop project backup, based on vendor/slua-standalone.1.0.67.nupkg  

## Run with sharpdevelop  
see sluamod_sharpdevelop.sln  
it copy slua.dll to output folder in project  

## About unmanaged code debugging  
Please use vs2013 to open sluamod_vs2013.sln  
Please check 'Enable native code debugging' in sluamod_vs2013 project Debug tab  
see https://www.technipages.com/visual-studio-native-code-debugging  
When debugging, click menu 'Debug->Exception' and enable all exceptions    
make breakpoint at LuaState.cs : internal static int print(IntPtr L)  

## (TODO) build vc6 slua.dll  
(TODO) use vc6 to open slua_vc6.dsw  
