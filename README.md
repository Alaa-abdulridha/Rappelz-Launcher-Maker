# Ursulita Project
**Tested on**: Windwos xp/7/8/8.1/10

**Tags**:C#, Rappelz, Launcher, game, server, RevolutionTeam

Thanks to [@gruce](https://github.com/gruce "@gruce") for helping.
# Description
This is new tools that released for first time .. this tools can help you to make the official launcher work with your server and the ptach_bin work too , also this tools is very easy to use and simple every one can use them easily but don't edit the tools without our perms the tools not encrypted by any way .

![enter image description here](https://i.epvpimg.com/ctfugab.png)



# **Features**

 
 - Making exe official launcher clean and easy with alot of features
   like fix the client, repacking etc..
 -   Making  **TPF**  files so the  patchbin  can read them .
 -   Hashing the Resource files (**Rdb,jpg,..etc**) ..
 -   The Launcher is updating directly to the **Data.00x**.
 -   You can update the  launcher  ,SFrame  or everything you want inside the client easy .
 -   This tool is totaly  safe  ..it working only on **vps** or  **SandBox**  .. only!. 

# Getting Started

Download the patch_bin and unrar it put it to your root server .. open port **3516** in your server firewall .  
**\Patch_bin\PatchInfo\ServerResource\Default.tpf** this file contain the web update server with the Appname that you will put in the launcher (**RZ_ME** for arabic) .  
Download Tools.rar that contain the patching tools **Rappelz 0xZ** Patch this tool is making the launcher (exe updater) launcher .  
  
PatchManager this tool is the tool that made the TPF files for the patch_bin and hashing the resource files .  
  
when you open the Patch manager tool if you want to encrypt (hash files) just click encode from the quick select then chose your appname (**RZ_ME**) for example the app name should be the same appname that you used in the launcher ! the Version is the update number **94000,94001**..etc  
  
then just drop your resource files in the tool .. (put your files like rdb ,,jpg in a folder then drag all the folder to the tool on Revolution logo ) you'll get 2 folders inside the folder that you dragged you need to upload the folders inside Target folder to your web update server that you put inside the Default.tpf , and the **TPF** update file with the date on this file copy it to your patchinfo folder in your patchbin path just put it with the same folder of the **Default.tpf**.Like this

    + server_directory
    |
    +--+ PatchServer.exe
    |
    +--+ PatchInfo
       |
       +--+ file1.tpf
       |
       +--+ file2.tpf
       ...
       
then restart your patchbin .  
  
When you hash your files you will get the **patchinfo.tpf** file it contain ..  
For example (**RZ_RU (94060) 2017-11-07 15-54-11.tpf**)

    sdXwe'vmvdeHga$:216:11935985:30CF20EB:6813532:37603A3D:/036/

-   **sdXwe'vmvdeHga$** is the file name (hashed, it's db_string.rdb)
-   **216** is the file's version
-   **11935985** the unpacked file size
-   **30CF20EB** the unpacked file's checksum (sum of all bytes)
-   **6813532** the packed size (it use zlib)
-   **37603A3D** the packed file's checksum (sum of all bytes)
-   **/036/** the folder where to find the file in the patch file server
So the launcher will read the tpf file ,url,size if everything is okay it will update and the download link for example will be  
http://rappelz.info/fr/RZ_FR/Patch/036/sdXwe'vmvdeHga$

Also inside the tool you will find the launcher Arguments list i hope it will help you..

# COMMANDS

-   set io.ip_mask 110.216.146.120;110.216.146.121 -->This command you need to put it in the prince to allow to this ip's only to login.
-   remove io.ip_mask 210.216.246.220;210.216.246.221 -->This command to delete the ip's and get the login back to public.
-   #suicide() -->Engine killing command
-   Update port:3516
-   Reload -->this command to reload the TPF files.

# FAQ

 1. Hey , i did everything but when i open the launcher it tells me
    cannot connect to index server

  


> 
> Please make sure your Appname in the Default.tpf , in the Tpf files and in the launcher.exe is the same for example RZ_ME in all of them.

 2. When i open the launcher it tells me cannot connect to update server
    !

  

> Make sure you opned the patch port in your firewall (3516)

  

 3. When i open the tool and i Drag the folder or the resource files
    nothing happed?

  


> Okay as i said before the tool is work only on VPS or SandBox .

 4. I did everything as you said but i get Error file size .. when i
    update by the launcher

  
  

> This mean the problem from your internet , or your Web update server
> (the server that contain the resource files) or you hashed the files
> by wrong way.
