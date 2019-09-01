function flash(file, width, height)
{
	document.write("<object classid='clsid:d27cdb6e-ae6d-11cf-96b8-444553540000' codebase='http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=8,0,0,0' width='"+width+"' height='"+height+"'>  <param name='movie' value='"+file+"'>  <param name='quality' value='high'>  <param name='wmode' value='transparent'><embed src='"+file+"' quality='high' pluginspage='http://www.macromedia.com/go/getflashplayer' type='application/x-shockwave-flash' width='"+width+"' height='"+height+"'></object>"); 
	
}


function showFlashObject(objID, objSource, objWidth, objHeight, objQuality, objWmode, objBgcolor){
	//page url
	var pageUrl=self.window.location.href;
	if(pageUrl.substring(0,5)=="https") swfUrl="https";
	else swfUrl="http";
	//default value setting
	if (objID=="") objID="ShockwaveFlash1";
	if (objWidth=="") objWidth="0";
	if (objHeight=="") objHeight="0";
	if (objQuality=="") objQuality="high";

	document.writeln('<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="'+swfUrl+'://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=8,0,0,0" width="'+objWidth+'" height="'+objHeight+'" id="'+objID+'" align="middle">');
	document.writeln('<param name="movie" value="'+objSource+'" />');
	document.writeln('<param name="allowScriptAccess" value="always" />');
	document.writeln('<param name="menu" value="false" />');
	document.writeln('<param name="quality" value="high" />');
	document.writeln('<param name="bgcolor" value="'+objBgcolor+'" />');
	document.writeln('<param name="wmode" value="'+objWmode+'" />');
	document.writeln('<embed src="'+objSource+'" allowScriptAccess="always" menu="false" quality="high" bgcolor="'+objBgcolor+'" wmode="'+objWmode+'" width="'+objWidth+'" height="'+objHeight+'" name="'+objID+'" id="'+objID+'" align="middle" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />');
	document.writeln('</object>');
}

function notice_setCookie( expiredays )
{
	var todayDate = new Date();
	todayDate.setDate( todayDate.getDate() + expiredays );
	document.cookie = "notOpenPro=1; path=/; expires=" + todayDate.toGMTString() + ";"
	self.close();
}

function goUrl(url){
	try
	{
		opener.location.href = url;
		opener.focus();
	}
	catch(e)
	{
		home = window.open(url, "home");
		home.focus();
	}	
}

