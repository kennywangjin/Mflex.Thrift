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


namespace Mflex.Thrift
{

    /// <summary>
    /// Used to perform Delete operations on a single row.
    /// 
    /// The scope can be further narrowed down by specifying a list of
    /// columns or column families as TColumns.
    /// 
    /// Specifying only a family in a TColumn will delete the whole family.
    /// If a timestamp is specified all versions with a timestamp less than
    /// or equal to this will be deleted. If no timestamp is specified the
    /// current time will be used.
    /// 
    /// Specifying a family and a column qualifier in a TColumn will delete only
    /// this qualifier. If a timestamp is specified only versions equal
    /// to this timestamp will be deleted. If no timestamp is specified the
    /// most recent version will be deleted.  To delete all previous versions,
    /// specify the DELETE_COLUMNS TDeleteType.
    /// 
    /// The top level timestamp is only used if a complete row should be deleted
    /// (i.e. no columns are passed) and if it is specified it works the same way
    /// as if you had added a TColumn for every column family and this timestamp
    /// (i.e. all versions older than or equal in all column families will be deleted)
    /// 
    /// You can specify how this Delete should be written to the write-ahead Log (WAL)
    /// by changing the durability. If you don't provide durability, it defaults to
    /// column family's default setting for durability.
    /// </summary>
    public partial class TDelete : TBase
    {
        private List<TColumn> _columns;
        private long _timestamp;
        private TDeleteType _deleteType;
        private Dictionary<byte[], byte[]> _attributes;
        private TDurability _durability;

        public byte[] Row { get; set; }

        public List<TColumn> Columns
        {
            get
            {
                return _columns;
            }
            set
            {
                __isset.columns = true;
                this._columns = value;
            }
        }

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

        /// <summary>
        /// 
        /// <seealso cref="TDeleteType"/>
        /// </summary>
        public TDeleteType DeleteType
        {
            get
            {
                return _deleteType;
            }
            set
            {
                __isset.deleteType = true;
                this._deleteType = value;
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


        public Isset __isset;
        public struct Isset
        {
            public bool columns;
            public bool timestamp;
            public bool deleteType;
            public bool attributes;
            public bool durability;
        }

        public TDelete()
        {
            this._deleteType = TDeleteType.DELETE_COLUMNS;
            this.__isset.deleteType = true;
        }

        public TDelete(byte[] row) : this()
        {
            this.Row = row;
        }

        public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
        {
            iprot.IncrementRecursionDepth();
            try
            {
                bool isset_row = false;
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
                                    TList _list26 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Columns = new List<TColumn>(_list26.Count);
                                    for (int _i27 = 0; _i27 < _list26.Count; ++_i27)
                                    {
                                        TColumn _elem28;
                                        _elem28 = new TColumn();
                                        await _elem28.ReadAsync(iprot, cancellationToken);
                                        Columns.Add(_elem28);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
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
                        case 4:
                            if (field.Type == TType.I32)
                            {
                                DeleteType = (TDeleteType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.Map)
                            {
                                {
                                    TMap _map29 = await iprot.ReadMapBeginAsync(cancellationToken);
                                    Attributes = new Dictionary<byte[], byte[]>(_map29.Count);
                                    for (int _i30 = 0; _i30 < _map29.Count; ++_i30)
                                    {
                                        byte[] _key31;
                                        byte[] _val32;
                                        _key31 = await iprot.ReadBinaryAsync(cancellationToken);
                                        _val32 = await iprot.ReadBinaryAsync(cancellationToken);
                                        Attributes[_key31] = _val32;
                                    }
                                    await iprot.ReadMapEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.I32)
                            {
                                Durability = (TDurability)await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TDelete");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                field.Name = "row";
                field.Type = TType.String;
                field.ID = 1;
                await oprot.WriteFieldBeginAsync(field, cancellationToken);
                await oprot.WriteBinaryAsync(Row, cancellationToken);
                await oprot.WriteFieldEndAsync(cancellationToken);
                if (Columns != null && __isset.columns)
                {
                    field.Name = "columns";
                    field.Type = TType.List;
                    field.ID = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Columns.Count), cancellationToken);
                        foreach (TColumn _iter33 in Columns)
                        {
                            await _iter33.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.timestamp)
                {
                    field.Name = "timestamp";
                    field.Type = TType.I64;
                    field.ID = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI64Async(Timestamp, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.deleteType)
                {
                    field.Name = "deleteType";
                    field.Type = TType.I32;
                    field.ID = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)DeleteType, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Attributes != null && __isset.attributes)
                {
                    field.Name = "attributes";
                    field.Type = TType.Map;
                    field.ID = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, Attributes.Count), cancellationToken);
                        foreach (byte[] _iter34 in Attributes.Keys)
                        {
                            await oprot.WriteBinaryAsync(_iter34, cancellationToken);
                            await oprot.WriteBinaryAsync(Attributes[_iter34], cancellationToken);
                        }
                        await oprot.WriteMapEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.durability)
                {
                    field.Name = "durability";
                    field.Type = TType.I32;
                    field.ID = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)Durability, cancellationToken);
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
            var other = that as TDelete;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return TCollections.Equals(Row, other.Row)
              && ((__isset.columns == other.__isset.columns) && ((!__isset.columns) || (TCollections.Equals(Columns, other.Columns))))
              && ((__isset.timestamp == other.__isset.timestamp) && ((!__isset.timestamp) || (System.Object.Equals(Timestamp, other.Timestamp))))
              && ((__isset.deleteType == other.__isset.deleteType) && ((!__isset.deleteType) || (System.Object.Equals(DeleteType, other.DeleteType))))
              && ((__isset.attributes == other.__isset.attributes) && ((!__isset.attributes) || (TCollections.Equals(Attributes, other.Attributes))))
              && ((__isset.durability == other.__isset.durability) && ((!__isset.durability) || (System.Object.Equals(Durability, other.Durability))));
        }

        public override int GetHashCode()
        {
            int hashcode = 157;
            unchecked
            {
                hashcode = (hashcode * 397) + Row.GetHashCode();
                if (__isset.columns)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Columns);
                if (__isset.timestamp)
                    hashcode = (hashcode * 397) + Timestamp.GetHashCode();
                if (__isset.deleteType)
                    hashcode = (hashcode * 397) + DeleteType.GetHashCode();
                if (__isset.attributes)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Attributes);
                if (__isset.durability)
                    hashcode = (hashcode * 397) + Durability.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("TDelete(");
            sb.Append(", Row: ");
            sb.Append(Row);
            if (Columns != null && __isset.columns)
            {
                sb.Append(", Columns: ");
                sb.Append(Columns);
            }
            if (__isset.timestamp)
            {
                sb.Append(", Timestamp: ");
                sb.Append(Timestamp);
            }
            if (__isset.deleteType)
            {
                sb.Append(", DeleteType: ");
                sb.Append(DeleteType);
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
            sb.Append(")");
            return sb.ToString();
        }
    }

}
