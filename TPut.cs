/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace Thrift
{

  /// <summary>
  /// Used to perform Put operations for a single row.
  /// 
  /// Add column values to this object and they'll be added.
  /// You can provide a default timestamp if the column values
  /// don't have one. If you don't provide a default timestamp
  /// the current time is inserted.
  /// 
  /// You can specify how this Put should be written to the write-ahead Log (WAL)
  /// by changing the durability. If you don't provide durability, it defaults to
  /// column family's default setting for durability.
  /// </summary>
  public partial class TPut : TBase
  {
    private long _timestamp;
    private Dictionary<byte[], byte[]> _attributes;
    private TDurability _durability;
    private TCellVisibility _cellVisibility;

    public byte[] Row { get; set; }

    public List<TColumnValue> ColumnValues { get; set; }

    public long Timestamp
    {
      get
      {
        return _timestamp;
      }
      set
      {
        __isset.timestamp = true;
        this._timestamp = value;
      }
    }

    public Dictionary<byte[], byte[]> Attributes
    {
      get
      {
        return _attributes;
      }
      set
      {
        __isset.attributes = true;
        this._attributes = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="TDurability"/>
    /// </summary>
    public TDurability Durability
    {
      get
      {
        return _durability;
      }
      set
      {
        __isset.durability = true;
        this._durability = value;
      }
    }

    public TCellVisibility CellVisibility
    {
      get
      {
        return _cellVisibility;
      }
      set
      {
        __isset.cellVisibility = true;
        this._cellVisibility = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool timestamp;
      public bool attributes;
      public bool durability;
      public bool cellVisibility;
    }

    public TPut()
    {
    }

    public TPut(byte[] row, List<TColumnValue> columnValues) : this()
    {
      this.Row = row;
      this.ColumnValues = columnValues;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_row = false;
        bool isset_columnValues = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                Row = await iprot.ReadBinaryAsync(cancellationToken);
                isset_row = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list17 = await iprot.ReadListBeginAsync(cancellationToken);
                  ColumnValues = new List<TColumnValue>(_list17.Count);
                  for(int _i18 = 0; _i18 < _list17.Count; ++_i18)
                  {
                    TColumnValue _elem19;
                    _elem19 = new TColumnValue();
                    await _elem19.ReadAsync(iprot, cancellationToken);
                    ColumnValues.Add(_elem19);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_columnValues = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Timestamp = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Map)
              {
                {
                  TMap _map20 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Attributes = new Dictionary<byte[], byte[]>(_map20.Count);
                  for(int _i21 = 0; _i21 < _map20.Count; ++_i21)
                  {
                    byte[] _key22;
                    byte[] _val23;
                    _key22 = await iprot.ReadBinaryAsync(cancellationToken);
                    _val23 = await iprot.ReadBinaryAsync(cancellationToken);
                    Attributes[_key22] = _val23;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.I32)
              {
                Durability = (TDurability)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.Struct)
              {
                CellVisibility = new TCellVisibility();
                await CellVisibility.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_row)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_columnValues)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("TPut");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "row";
        field.Type = TType.String;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBinaryAsync(Row, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "columnValues";
        field.Type = TType.List;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.Struct, ColumnValues.Count), cancellationToken);
          foreach (TColumnValue _iter24 in ColumnValues)
          {
            await _iter24.WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (__isset.timestamp)
        {
          field.Name = "timestamp";
          field.Type = TType.I64;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Timestamp, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Attributes != null && __isset.attributes)
        {
          field.Name = "attributes";
          field.Type = TType.Map;
          field.ID = 5;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, Attributes.Count), cancellationToken);
            foreach (byte[] _iter25 in Attributes.Keys)
            {
              await oprot.WriteBinaryAsync(_iter25, cancellationToken);
              await oprot.WriteBinaryAsync(Attributes[_iter25], cancellationToken);
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.durability)
        {
          field.Name = "durability";
          field.Type = TType.I32;
          field.ID = 6;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async((int)Durability, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (CellVisibility != null && __isset.cellVisibility)
        {
          field.Name = "cellVisibility";
          field.Type = TType.Struct;
          field.ID = 7;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await CellVisibility.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as TPut;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return TCollections.Equals(Row, other.Row)
        && TCollections.Equals(ColumnValues, other.ColumnValues)
        && ((__isset.timestamp == other.__isset.timestamp) && ((!__isset.timestamp) || (System.Object.Equals(Timestamp, other.Timestamp))))
        && ((__isset.attributes == other.__isset.attributes) && ((!__isset.attributes) || (TCollections.Equals(Attributes, other.Attributes))))
        && ((__isset.durability == other.__isset.durability) && ((!__isset.durability) || (System.Object.Equals(Durability, other.Durability))))
        && ((__isset.cellVisibility == other.__isset.cellVisibility) && ((!__isset.cellVisibility) || (System.Object.Equals(CellVisibility, other.CellVisibility))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Row.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(ColumnValues);
        if(__isset.timestamp)
          hashcode = (hashcode * 397) + Timestamp.GetHashCode();
        if(__isset.attributes)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Attributes);
        if(__isset.durability)
          hashcode = (hashcode * 397) + Durability.GetHashCode();
        if(__isset.cellVisibility)
          hashcode = (hashcode * 397) + CellVisibility.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TPut(");
      sb.Append(", Row: ");
      sb.Append(Row);
      sb.Append(", ColumnValues: ");
      sb.Append(ColumnValues);
      if (__isset.timestamp)
      {
        sb.Append(", Timestamp: ");
        sb.Append(Timestamp);
      }
      if (Attributes != null && __isset.attributes)
      {
        sb.Append(", Attributes: ");
        sb.Append(Attributes);
      }
      if (__isset.durability)
      {
        sb.Append(", Durability: ");
        sb.Append(Durability);
      }
      if (CellVisibility != null && __isset.cellVisibility)
      {
        sb.Append(", CellVisibility: ");
        sb.Append(CellVisibility== null ? "<null>" : CellVisibility.ToString());
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
