using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Win32;
using System;


namespace reg_editor
{
    class Program
    {
        private static int Main(string[] args)
        {
            Console.WriteLine("Hello World! I will help you edit Windows registry keys in less of a pain.");
            Console.WriteLine("");
            Console.WriteLine("Press 1 to add a registry key, It is important I be run as Administrator to work correctly. Be VERY warned, modifying or deleting registry keys when not knowiing what your doing could make your system unuseable.");
            Console.WriteLine("Please input the path of registry key. Press 1 for HKEY_CLASSES_ROOT, 2 for HKEY_CURRENT_USER, 3 for HKEY_LOCAL_MACHINE, 4 for HKEY_USERS, 5 for HKEY_CURRENT_CONFIG");
            int aaction = Convert.ToInt32(Console.ReadLine());
            switch (aaction)

            {
                case 1:
                    Console.WriteLine("I will check if the key exists. If the key does exist, I will edit it with your updates. You will also be shown the current value of the key beofre editing.  Please input the directory of the key you wish to create followed by the name with no spaces.");
                    Console.WriteLine("");

                    string regkeyp = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Please input the name of registry key.");
                    string regkeyc = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please input the value of registry key.");
                    string regkeyc1 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please 2n input the value of registry key.");
                    string regkeyc2 = Convert.ToString(Console.ReadLine());
                    Microsoft.Win32.RegistryKey key;

                    key = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(regkeyc);
                    key.SetValue(regkeyc1, regkeyc2);
                    Registry.LocalMachine.OpenSubKey(regkeyc, true);

                    string value = regkeyc1;
                    string value2 = regkeyc2;

                    if (key != null)
                    {
                        value = key.GetValue(regkeyc1, regkeyc2).ToString();
                        Console.WriteLine("The value of your first key is", regkeyc1);
                        Console.WriteLine("");
                        Console.WriteLine("The value of your second key is", value2);
                    }


                    Console.WriteLine(regkeyc1, value2);
                    Console.WriteLine("I have created or edited your key with the respective values. Exiting now.");
                    key.Close();
                    break;

                case 2:
                    Console.WriteLine("I will check if the key exists. If the key does exist, I will edit it with your updates. You will also be shown the current value of the key beofre editing.  Please input the directory of the key you wish to create followed by the name with no spaces.");
                    Console.WriteLine("");

                    Console.WriteLine("Please input the name of registry key.");
                    string regkeycb = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please input the value of registry key.");
                    string regkeycb1 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please 2n input the value of registry key.");
                    string regkeycb2 = Convert.ToString(Console.ReadLine());
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regkeycb);
                    key.SetValue(regkeycb1, regkeycb2);
                    Console.WriteLine("I have created or edited your key with the respective values. Exiting now.");


                    string value3 = regkeycb2;

                    if (key != null)
                    {
                        value = key.GetValue(regkeycb1, regkeycb2).ToString();
                        Console.WriteLine("The value of your first key is", regkeycb1);
                        Console.WriteLine("");
                        Console.WriteLine("The value of your second key is", value3);
                    }


                    Console.WriteLine(regkeycb1, value3);
                    Console.WriteLine("I have created or edited your key with the respective values. Exiting now.");
                    key.Close();
                    break;
                case 3:
                    Console.WriteLine("I will check if the key exists. If the key does exist, I will edit it with your updates. You will also be shown the current value of the key beofre editing.  Please input the directory of the key you wish to create followed by the name with no spaces.");
                    Console.WriteLine("");

                    Console.WriteLine("Please input the name of registry key.");
                    string regkeycb3 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please input the value of registry key.");
                    string regkeycb4 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please 2n input the value of registry key.");
                    string regkeycb5 = Convert.ToString(Console.ReadLine());
                    key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(regkeycb3);
                    key.SetValue(regkeycb4, regkeycb5);
                    Console.WriteLine("I have created or edited your key with the respective values. Exiting now.");



                    if (key != null)
                    {
                        value = key.GetValue(regkeycb4, regkeycb5).ToString();
                        Console.WriteLine("The value of your first key is", regkeycb4);
                        Console.WriteLine("");

                        Console.WriteLine("The value of your second key is", regkeycb5);
                    }


                    Console.WriteLine(regkeycb4, regkeycb5);
                    Console.WriteLine("I have created or edited your key with the respective values. Exiting now.");
                    break;

                case 4:
                    Console.WriteLine("I will check if the key exists. If the key does exist, I will edit it with your updates. You will also be shown the current value of the key beofre editing.  Please input the directory of the key you wish to create followed by the name with no spaces.");
                    Console.WriteLine("");

                    Console.WriteLine("Please input the name of registry key.");
                    string regkeycb6 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please input the value of registry key.");
                    string regkeycb7 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please 2n input the value of registry key.");
                    string regkeycb8 = Convert.ToString(Console.ReadLine());
                    key = Microsoft.Win32.Registry.Users.CreateSubKey(regkeycb8);
                    key.SetValue(regkeycb7, regkeycb8);
                    Console.WriteLine("I have created or edited your key with the respective values. Exiting now.");





                    if (key != null)
                    {
                        value = key.GetValue(regkeycb7, regkeycb8).ToString();
                        Console.WriteLine("The value of your first key is", regkeycb7);
                        Console.WriteLine(""); 
                        Console.WriteLine("The value of your second key is", regkeycb8);
                    }




                    Console.WriteLine(regkeycb7, regkeycb8);

                    Console.WriteLine("I have created or edited your key with the respective values. Exiting now.");
                    key.Close();
                    break;

                case 5:

                    Console.WriteLine("I will check if the key exists. If the key does exist, I will edit it with your updates. You will also be shown the current value of the key beofre editing.  Please input the directory of the key you wish to create followed by the name with no spaces.");
                    Console.WriteLine("");

                    Console.WriteLine("Please input the name of registry key.");
                    string regkeycb9 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please input the value of registry key.");
                    string regkeycb10 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please 2n input the value of registry key.");
                    string regkeycb11 = Convert.ToString(Console.ReadLine());
                    key = Microsoft.Win32.Registry.CurrentConfig.CreateSubKey(regkeycb9);
                    key.SetValue(regkeycb10, regkeycb11);

                    Console.WriteLine("I have created or edited your key with the respective values. Exiting now.");

                    if (key != null)
                    {
                        value = key.GetValue(regkeycb10, regkeycb11).ToString();
                        Console.WriteLine("The value of your first key is", regkeycb10);
                        Console.WriteLine("");
                        Console.WriteLine("The value of your second key is", regkeycb11);
                    }


                    Console.WriteLine();
                    Console.WriteLine("I have created or edited your key with the respective values. Exiting now.");
                    key.Close();
                    break;

                case 6:
                    Console.WriteLine("Use this command to delete registry keys. Type reg delete then the path of the key, and I will delete it for you.");
                   
                    Console.WriteLine("");

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "reg edit ";
                    process.StartInfo = startInfo;
                    process.Start();
                    break;
            }
                    return aaction;
            }
        }
    }

