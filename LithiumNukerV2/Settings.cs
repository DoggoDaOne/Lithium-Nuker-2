using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// All of the settings can be changed from here

namespace LithiumNukerV2
{
    public class Settings
    {
        public static bool Debug = false;
        
        public static readonly string Logo = @"                                                                                                                                                                                                      
DDDDDDDDDDDDD                                                                                       NNNNNNNN        NNNNNNNN                  kkkkkkkk                                                
D::::::::::::DDD                                                                                    N:::::::N       N::::::N                  k::::::k                                                
D:::::::::::::::DD                                                                                  N::::::::N      N::::::N                  k::::::k                                                
DDD:::::DDDDD:::::D                                                                                 N:::::::::N     N::::::N                  k::::::k                                                
  D:::::D    D:::::D    ooooooooooo      ggggggggg   ggggg   ggggggggg   ggggg   ooooooooooo        N::::::::::N    N::::::Nuuuuuu    uuuuuu   k:::::k    kkkkkkk eeeeeeeeeeee    rrrrr   rrrrrrrrr   
  D:::::D     D:::::D oo:::::::::::oo   g:::::::::ggg::::g  g:::::::::ggg::::g oo:::::::::::oo      N:::::::::::N   N::::::Nu::::u    u::::u   k:::::k   k:::::kee::::::::::::ee  r::::rrr:::::::::r  
  D:::::D     D:::::Do:::::::::::::::o g:::::::::::::::::g g:::::::::::::::::go:::::::::::::::o     N:::::::N::::N  N::::::Nu::::u    u::::u   k:::::k  k:::::ke::::::eeeee:::::eer:::::::::::::::::r 
  D:::::D     D:::::Do:::::ooooo:::::og::::::ggggg::::::ggg::::::ggggg::::::ggo:::::ooooo:::::o     N::::::N N::::N N::::::Nu::::u    u::::u   k:::::k k:::::ke::::::e     e:::::err::::::rrrrr::::::r
  D:::::D     D:::::Do::::o     o::::og:::::g     g:::::g g:::::g     g:::::g o::::o     o::::o     N::::::N  N::::N:::::::Nu::::u    u::::u   k::::::k:::::k e:::::::eeeee::::::e r:::::r     r:::::r
  D:::::D     D:::::Do::::o     o::::og:::::g     g:::::g g:::::g     g:::::g o::::o     o::::o     N::::::N   N:::::::::::Nu::::u    u::::u   k:::::::::::k  e:::::::::::::::::e  r:::::r     rrrrrrr
  D:::::D     D:::::Do::::o     o::::og:::::g     g:::::g g:::::g     g:::::g o::::o     o::::o     N::::::N    N::::::::::Nu::::u    u::::u   k:::::::::::k  e::::::eeeeeeeeeee   r:::::r            
  D:::::D    D:::::D o::::o     o::::og::::::g    g:::::g g::::::g    g:::::g o::::o     o::::o     N::::::N     N:::::::::Nu:::::uuuu:::::u   k::::::k:::::k e:::::::e            r:::::r            
DDD:::::DDDDD:::::D  o:::::ooooo:::::og:::::::ggggg:::::g g:::::::ggggg:::::g o:::::ooooo:::::o     N::::::N      N::::::::Nu:::::::::::::::uuk::::::k k:::::ke::::::::e           r:::::r            
D:::::::::::::::DD   o:::::::::::::::o g::::::::::::::::g  g::::::::::::::::g o:::::::::::::::o     N::::::N       N:::::::N u:::::::::::::::uk::::::k  k:::::ke::::::::eeeeeeee   r:::::r            
D::::::::::::DDD      oo:::::::::::oo   gg::::::::::::::g   gg::::::::::::::g  oo:::::::::::oo      N::::::N        N::::::N  uu::::::::uu:::uk::::::k   k:::::kee:::::::::::::e   r:::::r            
DDDDDDDDDDDDD           ooooooooooo       gggggggg::::::g     gggggggg::::::g    ooooooooooo        NNNNNNNN         NNNNNNN    uuuuuuuu  uuuukkkkkkkk    kkkkkkk eeeeeeeeeeeeee   rrrrrrr            
                                                  g:::::g             g:::::g                                                                                                                         
                                      gggggg      g:::::g gggggg      g:::::g                                                                                                                         
                                      g:::::gg   gg:::::g g:::::gg   gg:::::g                                                                                                                         
                                       g::::::ggg:::::::g  g::::::ggg:::::::g                                                                                                                         
                                        gg:::::::::::::g    gg:::::::::::::g                                                                                                                          
                                          ggg::::::ggg        ggg::::::ggg                                                                                                                            
                                             gggggg              gggggg                   
           ";
        public static string Token;
        public static long? GuildId = null;
        public static int Threads = 40;
        public static int ConnectionLimit = 25; // 10 concurrent connections
        public static readonly string WebhookName = ".gg/lithium runs cord";
        public static readonly string AvatarUrl = "https://camo.githubusercontent.com/450b75468a748fbd8e4b3116c378cc9cfdcadd8b0b0e676821a6f873fcb85f53/68747470733a2f2f7665726c6f782e63632f7261772f535865475144";
    }
}
