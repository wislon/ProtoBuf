﻿//
//	This is the backend code for reading and writing
//	Report bugs to: https://silentorbit.com/protobuf-csharpgen/
//
//	Generated by ProtocolBuffer
//	- a pure c# code generation implementation of protocol buffers
//

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using ExampleNamespace;

namespace ProtocolBuffers
{
	public static partial class Serializer
	{

		public static class Person
		{
			public static ExampleNamespace.Person Read(Stream stream)
			{
				ExampleNamespace.Person instance = new ExampleNamespace.Person();
				Serializer.Read(stream, instance);
				return instance;
			}
			
			public static ExampleNamespace.Person Read(byte[] buffer)
			{
				using(MemoryStream ms = new MemoryStream(buffer))
					return Read(ms);
			}
			
			public static T Read<T> (Stream stream) where T : ExampleNamespace.IPerson, new()
			{
				T instance = new T ();
				Serializer.Read (stream, instance);
				return instance;
			}
			
			public static T Read<T> (byte[] buffer) where T : ExampleNamespace.IPerson, new()
			{
				T instance = new T ();
				using (MemoryStream ms = new MemoryStream(buffer))
					Serializer.Read (ms, instance);
				return instance;
			}
		
			public static void Write(Stream stream, ExampleNamespace.IPerson instance)
			{
				Serializer.Write(stream, instance);
			}
		
			public static class PhoneNumber
			{
				public static ExampleNamespace.Person.PhoneNumber Read(Stream stream)
				{
					ExampleNamespace.Person.PhoneNumber instance = new ExampleNamespace.Person.PhoneNumber();
					Serializer.Read(stream, instance);
					return instance;
				}
				
				public static ExampleNamespace.Person.PhoneNumber Read(byte[] buffer)
				{
					using(MemoryStream ms = new MemoryStream(buffer))
						return Read(ms);
				}
				
				public static T Read<T> (Stream stream) where T : ExampleNamespace.Person.IPhoneNumber, new()
				{
					T instance = new T ();
					Serializer.Read (stream, instance);
					return instance;
				}
				
				public static T Read<T> (byte[] buffer) where T : ExampleNamespace.Person.IPhoneNumber, new()
				{
					T instance = new T ();
					using (MemoryStream ms = new MemoryStream(buffer))
						Serializer.Read (ms, instance);
					return instance;
				}
			
				public static void Write(Stream stream, ExampleNamespace.Person.IPhoneNumber instance)
				{
					Serializer.Write(stream, instance);
				}
			}
			
		}
		

		public static class MyMessageV1
		{
			public static ExampleNamespace.MyMessageV1 Read(Stream stream)
			{
				ExampleNamespace.MyMessageV1 instance = new ExampleNamespace.MyMessageV1();
				Serializer.Read(stream, instance);
				return instance;
			}
			
			public static ExampleNamespace.MyMessageV1 Read(byte[] buffer)
			{
				using(MemoryStream ms = new MemoryStream(buffer))
					return Read(ms);
			}
			
			public static T Read<T> (Stream stream) where T : ExampleNamespace.IMyMessageV1, new()
			{
				T instance = new T ();
				Serializer.Read (stream, instance);
				return instance;
			}
			
			public static T Read<T> (byte[] buffer) where T : ExampleNamespace.IMyMessageV1, new()
			{
				T instance = new T ();
				using (MemoryStream ms = new MemoryStream(buffer))
					Serializer.Read (ms, instance);
				return instance;
			}
		
			public static void Write(Stream stream, ExampleNamespace.IMyMessageV1 instance)
			{
				Serializer.Write(stream, instance);
			}
		}
		

		public static class MyMessageV2
		{
			public static ExampleNamespace.MyMessageV2 Read(Stream stream)
			{
				ExampleNamespace.MyMessageV2 instance = new ExampleNamespace.MyMessageV2();
				Serializer.Read(stream, instance);
				return instance;
			}
			
			public static ExampleNamespace.MyMessageV2 Read(byte[] buffer)
			{
				using(MemoryStream ms = new MemoryStream(buffer))
					return Read(ms);
			}
			
			public static T Read<T> (Stream stream) where T : ExampleNamespace.IMyMessageV2, new()
			{
				T instance = new T ();
				Serializer.Read (stream, instance);
				return instance;
			}
			
			public static T Read<T> (byte[] buffer) where T : ExampleNamespace.IMyMessageV2, new()
			{
				T instance = new T ();
				using (MemoryStream ms = new MemoryStream(buffer))
					Serializer.Read (ms, instance);
				return instance;
			}
		
			public static void Write(Stream stream, ExampleNamespace.IMyMessageV2 instance)
			{
				Serializer.Write(stream, instance);
			}
		}
		

		public static class TheirMessage
		{
			public static ExampleNamespace.TheirMessage Read(Stream stream)
			{
				ExampleNamespace.TheirMessage instance = new ExampleNamespace.TheirMessage();
				Serializer.Read(stream, instance);
				return instance;
			}
			
			public static ExampleNamespace.TheirMessage Read(byte[] buffer)
			{
				using(MemoryStream ms = new MemoryStream(buffer))
					return Read(ms);
			}
			
			public static T Read<T> (Stream stream) where T : ExampleNamespace.ITheirMessage, new()
			{
				T instance = new T ();
				Serializer.Read (stream, instance);
				return instance;
			}
			
			public static T Read<T> (byte[] buffer) where T : ExampleNamespace.ITheirMessage, new()
			{
				T instance = new T ();
				using (MemoryStream ms = new MemoryStream(buffer))
					Serializer.Read (ms, instance);
				return instance;
			}
		
			public static void Write(Stream stream, ExampleNamespace.ITheirMessage instance)
			{
				Serializer.Write(stream, instance);
			}
		}
		

		
		public static ExampleNamespace.IPerson Read (Stream stream, ExampleNamespace.IPerson instance)
		{
			while (true)
			{
				Key key = null;
				try {
					key = ProtocolParser.ReadKey (stream);
				} catch (InvalidDataException) {
					break;
				}
		
				switch (key.Field) {
				case 1:
					instance.Name = ProtocolParser.ReadString(stream);
					break;
				case 2:
					instance.Id = (int)ProtocolParser.ReadUInt32(stream);
					break;
				case 3:
					instance.Email = ProtocolParser.ReadString(stream);
					break;
				case 4:
					instance.Phone.Add(Person.PhoneNumber.Read(ProtocolParser.ReadBytes(stream)));
					break;
				default:
					ProtocolParser.SkipKey(stream, key);
					break;
				}
			}
			return instance;
		}
		
		public static ExampleNamespace.IPerson Read(byte[] buffer, ExampleNamespace.IPerson instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Read (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, ExampleNamespace.IPerson instance)
		{
			if(instance.Name == null)
				throw new ArgumentNullException("Name", "Required by proto specification.");
			ProtocolParser.WriteKey(stream, new Key(1, Wire.LengthDelimited));
			ProtocolParser.WriteString(stream, instance.Name);
			ProtocolParser.WriteKey(stream, new Key(2, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.Id);
			if(instance.Email != null)
			{
				ProtocolParser.WriteKey(stream, new Key(3, Wire.LengthDelimited));
				ProtocolParser.WriteString(stream, instance.Email);
			}
			foreach (ExampleNamespace.Person.IPhoneNumber i4 in instance.Phone)
			{
				ProtocolParser.WriteKey(stream, new Key(4, Wire.LengthDelimited));
				using(MemoryStream ms4 = new MemoryStream())
				{
					Write(ms4, i4);
					ProtocolParser.WriteBytes(stream, ms4.ToArray());
				}
			
			}
		}
		
		
		
		public static ExampleNamespace.Person.IPhoneNumber Read (Stream stream, ExampleNamespace.Person.IPhoneNumber instance)
		{
			while (true)
			{
				Key key = null;
				try {
					key = ProtocolParser.ReadKey (stream);
				} catch (InvalidDataException) {
					break;
				}
		
				switch (key.Field) {
				case 1:
					instance.Number = ProtocolParser.ReadString(stream);
					break;
				case 2:
					instance.Type = (ExampleNamespace.Person.PhoneType)ProtocolParser.ReadUInt32(stream);
					break;
				default:
					ProtocolParser.SkipKey(stream, key);
					break;
				}
			}
			return instance;
		}
		
		public static ExampleNamespace.Person.IPhoneNumber Read(byte[] buffer, ExampleNamespace.Person.IPhoneNumber instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Read (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, ExampleNamespace.Person.IPhoneNumber instance)
		{
			if(instance.Number == null)
				throw new ArgumentNullException("Number", "Required by proto specification.");
			ProtocolParser.WriteKey(stream, new Key(1, Wire.LengthDelimited));
			ProtocolParser.WriteString(stream, instance.Number);
			if(instance.Type != ExampleNamespace.Person.PhoneType.HOME)
			{
				ProtocolParser.WriteKey(stream, new Key(2, Wire.Varint));
				ProtocolParser.WriteUInt32(stream, (uint)instance.Type);
			}
		}
		

		
		public static ExampleNamespace.IMyMessageV1 Read (Stream stream, ExampleNamespace.IMyMessageV1 instance)
		{
			while (true)
			{
				Key key = null;
				try {
					key = ProtocolParser.ReadKey (stream);
				} catch (InvalidDataException) {
					break;
				}
		
				switch (key.Field) {
				case 1:
					instance.FieldA = (int)ProtocolParser.ReadUInt32(stream);
					break;
				default:
					ProtocolParser.SkipKey(stream, key);
					break;
				}
			}
			return instance;
		}
		
		public static ExampleNamespace.IMyMessageV1 Read(byte[] buffer, ExampleNamespace.IMyMessageV1 instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Read (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, ExampleNamespace.IMyMessageV1 instance)
		{
			ProtocolParser.WriteKey(stream, new Key(1, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldA);
		}
		

		
		public static ExampleNamespace.IMyMessageV2 Read (Stream stream, ExampleNamespace.IMyMessageV2 instance)
		{
			BinaryReader br = new BinaryReader (stream);	while (true)
			{
				Key key = null;
				try {
					key = ProtocolParser.ReadKey (stream);
				} catch (InvalidDataException) {
					break;
				}
		
				switch (key.Field) {
				case 1:
					instance.FieldA = (int)ProtocolParser.ReadUInt32(stream);
					break;
				case 2:
					instance.FieldB = br.ReadDouble ();
					break;
				case 3:
					instance.FieldC = br.ReadSingle ();
					break;
				case 4:
					instance.FieldD = (int)ProtocolParser.ReadUInt32(stream);
					break;
				case 5:
					instance.FieldE = (long)ProtocolParser.ReadUInt64(stream);
					break;
				case 6:
					instance.FieldF = ProtocolParser.ReadUInt32(stream);
					break;
				case 7:
					instance.FieldG = ProtocolParser.ReadUInt64(stream);;
					break;
				case 8:
					instance.FieldH = ProtocolParser.ReadSInt32(stream);;
					break;
				case 9:
					instance.FieldI = ProtocolParser.ReadSInt64(stream);;
					break;
				case 10:
					instance.FieldJ = br.ReadUInt32 ();
					break;
				case 11:
					instance.FieldK = br.ReadUInt64 ();
					break;
				case 12:
					instance.FieldL = br.ReadInt32 ();
					break;
				case 13:
					instance.FieldM = br.ReadInt64 ();
					break;
				case 14:
					instance.FieldN = ProtocolParser.ReadBool(stream);
					break;
				case 15:
					instance.FieldO = ProtocolParser.ReadString(stream);
					break;
				case 16:
					instance.FieldP = ProtocolParser.ReadBytes(stream);
					break;
				case 17:
					instance.FieldQ = (ExampleNamespace.MyMessageV2.MyEnum)ProtocolParser.ReadUInt32(stream);
					break;
				case 18:
					instance.FieldR = (ExampleNamespace.MyMessageV2.MyEnum)ProtocolParser.ReadUInt32(stream);
					break;
				case 19:
					instance.Dummy = ProtocolParser.ReadString(stream);
					break;
				case 20:
					instance.FieldS.Add(ProtocolParser.ReadUInt32(stream));
					break;
				case 21:
					using(MemoryStream ms21 = new MemoryStream(ProtocolParser.ReadBytes(stream)))
					{
						while(true)
						{
							if(ms21.Position == ms21.Length)
								break;
							instance.FieldT.Add(ProtocolParser.ReadUInt32(ms21));
						}
					}
		
					break;
				case 22:
					if(instance.FieldU == null)
						instance.FieldU = new ExampleNamespace.TheirMessage();
					instance.FieldU = Read(ProtocolParser.ReadBytes(stream), instance.FieldU);
					break;
				case 23:
					instance.FieldV.Add(TheirMessage.Read(ProtocolParser.ReadBytes(stream)));
					break;
				default:
					ProtocolParser.SkipKey(stream, key);
					break;
				}
			}
			return instance;
		}
		
		public static ExampleNamespace.IMyMessageV2 Read(byte[] buffer, ExampleNamespace.IMyMessageV2 instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Read (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, ExampleNamespace.IMyMessageV2 instance)
		{
			BinaryWriter bw = new BinaryWriter(stream);
			ProtocolParser.WriteKey(stream, new Key(1, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldA);
			ProtocolParser.WriteKey(stream, new Key(2, Wire.Fixed64));
			bw.Write(instance.FieldB);
			ProtocolParser.WriteKey(stream, new Key(3, Wire.Fixed32));
			bw.Write(instance.FieldC);
			ProtocolParser.WriteKey(stream, new Key(4, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldD);
			ProtocolParser.WriteKey(stream, new Key(5, Wire.Varint));
			ProtocolParser.WriteUInt64(stream, (ulong)instance.FieldE);
			ProtocolParser.WriteKey(stream, new Key(6, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, instance.FieldF);
			ProtocolParser.WriteKey(stream, new Key(7, Wire.Varint));
			ProtocolParser.WriteUInt64(stream, instance.FieldG);
			ProtocolParser.WriteKey(stream, new Key(8, Wire.Varint));
			ProtocolParser.WriteSInt32(stream, instance.FieldH);
			ProtocolParser.WriteKey(stream, new Key(9, Wire.Varint));
			ProtocolParser.WriteSInt64(stream, instance.FieldI);
			ProtocolParser.WriteKey(stream, new Key(10, Wire.Fixed32));
			bw.Write(instance.FieldJ);
			ProtocolParser.WriteKey(stream, new Key(11, Wire.Fixed64));
			bw.Write(instance.FieldK);
			ProtocolParser.WriteKey(stream, new Key(12, Wire.Fixed32));
			bw.Write(instance.FieldL);
			ProtocolParser.WriteKey(stream, new Key(13, Wire.Fixed64));
			bw.Write(instance.FieldM);
			ProtocolParser.WriteKey(stream, new Key(14, Wire.Varint));
			ProtocolParser.WriteBool(stream, instance.FieldN);
			if(instance.FieldO == null)
				throw new ArgumentNullException("FieldO", "Required by proto specification.");
			ProtocolParser.WriteKey(stream, new Key(15, Wire.LengthDelimited));
			ProtocolParser.WriteString(stream, instance.FieldO);
			if(instance.FieldP == null)
				throw new ArgumentNullException("FieldP", "Required by proto specification.");
			ProtocolParser.WriteKey(stream, new Key(16, Wire.LengthDelimited));
			ProtocolParser.WriteBytes(stream, instance.FieldP);
			ProtocolParser.WriteKey(stream, new Key(17, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldQ);
			if(instance.FieldR != ExampleNamespace.MyMessageV2.MyEnum.ETest2)
			{
				ProtocolParser.WriteKey(stream, new Key(18, Wire.Varint));
				ProtocolParser.WriteUInt32(stream, (uint)instance.FieldR);
			}
			if(instance.Dummy != null)
			{
				ProtocolParser.WriteKey(stream, new Key(19, Wire.LengthDelimited));
				ProtocolParser.WriteString(stream, instance.Dummy);
			}
			foreach (uint i20 in instance.FieldS)
			{
				ProtocolParser.WriteKey(stream, new Key(20, Wire.Varint));
				ProtocolParser.WriteUInt32(stream, i20);
			
			}
			ProtocolParser.WriteKey(stream, new Key(21, Wire.LengthDelimited));
			using(MemoryStream ms21 = new MemoryStream())
			{	
				foreach (uint i21 in instance.FieldT)
				{
					ProtocolParser.WriteUInt32(ms21, i21);
			
				}
				ProtocolParser.WriteBytes(stream, ms21.ToArray());
			}
			if(instance.FieldU != null)
			{
				ProtocolParser.WriteKey(stream, new Key(22, Wire.LengthDelimited));
				using(MemoryStream ms22 = new MemoryStream())
				{
					Write(ms22, instance.FieldU);
					ProtocolParser.WriteBytes(stream, ms22.ToArray());
				}
			}
			foreach (ExampleNamespace.ITheirMessage i23 in instance.FieldV)
			{
				ProtocolParser.WriteKey(stream, new Key(23, Wire.LengthDelimited));
				using(MemoryStream ms23 = new MemoryStream())
				{
					Write(ms23, i23);
					ProtocolParser.WriteBytes(stream, ms23.ToArray());
				}
			
			}
		}
		

		
		public static ExampleNamespace.ITheirMessage Read (Stream stream, ExampleNamespace.ITheirMessage instance)
		{
			while (true)
			{
				Key key = null;
				try {
					key = ProtocolParser.ReadKey (stream);
				} catch (InvalidDataException) {
					break;
				}
		
				switch (key.Field) {
				case 1:
					instance.FieldA = (int)ProtocolParser.ReadUInt32(stream);
					break;
				default:
					ProtocolParser.SkipKey(stream, key);
					break;
				}
			}
			return instance;
		}
		
		public static ExampleNamespace.ITheirMessage Read(byte[] buffer, ExampleNamespace.ITheirMessage instance)
		{
			using (MemoryStream ms = new MemoryStream(buffer))
				Read (ms, instance);
			return instance;
		}
		
		public static void Write(Stream stream, ExampleNamespace.ITheirMessage instance)
		{
			ProtocolParser.WriteKey(stream, new Key(1, Wire.Varint));
			ProtocolParser.WriteUInt32(stream, (uint)instance.FieldA);
		}
		


	}
}