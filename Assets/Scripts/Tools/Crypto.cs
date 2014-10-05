﻿using UnityEngine;
using System.Collections;
using System.Text;
using System;
using System.Security.Cryptography;

public class Crypto{

	public string EncryptData(string toEncrypt, string key)
	{
		byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);

		// 256-AES key
		byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
		RijndaelManaged rDel = new RijndaelManaged();
		
		rDel.Key = keyArray;
		rDel.Mode = CipherMode.ECB;
		
		rDel.Padding = PaddingMode.PKCS7;
		
		ICryptoTransform cTransform = rDel.CreateEncryptor();
		byte[] resultArray = cTransform.TransformFinalBlock (toEncryptArray, 0, toEncryptArray.Length);
		
		return Convert.ToBase64String (resultArray, 0, resultArray.Length);
	}
	
	
	public string DecryptData(string toDecrypt, string key)
	{
		byte[] keyArray = UTF8Encoding.UTF8.GetBytes (key);
		
		// AES-256 key
		byte[] toEncryptArray = Convert.FromBase64String (toDecrypt);
		RijndaelManaged rDel = new RijndaelManaged ();
		rDel.Key = keyArray;
		rDel.Mode = CipherMode.ECB;
		
		
		rDel.Padding = PaddingMode.PKCS7;
		
		// better lang support
		ICryptoTransform cTransform = rDel.CreateDecryptor ();
		
		byte[] resultArray = cTransform.TransformFinalBlock (toEncryptArray, 0, toEncryptArray.Length);
		
		return UTF8Encoding.UTF8.GetString (resultArray);
	}
}
