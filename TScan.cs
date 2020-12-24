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
    /// Any timestamps in the columns are ignored but the colFamTimeRangeMap included, use timeRange to select by timestamp.
    /// Max versions defaults to 1.
    /// </summary>
    public partial class TScan : TBase
    {
        private byte[] _startRow;
        private byte[] _stopRow;
        private List<TColumn> _columns;
        private int _caching;
        private int _maxVersions;
        private TTimeRange _timeRange;
        private byte[] _filterString;
        private int _batchSize;
        private Dictionary<byte[], byte[]> _attributes;
        private TAuthorization _authorizations;
        private bool _reversed;
        private bool _cacheBlocks;
        private Dictionary<byte[], TTimeRange> _colFamTimeRangeMap;
        private TReadType _readType;
        private int _limit;

        public byte[] StartRow
        {
            get
            {
                return _startRow;
            }
            set
            {
                __isset.startRow = true;
                this._startRow = value;
            }
        }

        public byte[] StopRow
        {
            get
            {
                return _stopRow;
            }
            set
            {
                __isset.stopRow = true;
                this._stopRow = value;
            }
        }

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

        public int Caching
        {
            get
            {
                return _caching;
            }
            set
            {
                __isset.caching = true;
                this._caching = value;
            }
        }

        public int MaxVersions
        {
            get
            {
                return _maxVersions;
            }
            set
            {
                __isset.maxVersions = true;
                this._maxVersions = value;
            }
        }

        public TTimeRange TimeRange
        {
            get
            {
                return _timeRange;
            }
            set
            {
                __isset.timeRange = true;
                this._timeRange = value;
            }
        }

        public byte[] FilterString
        {
            get
            {
                return _filterString;
            }
            set
            {
                __isset.filterString = true;
                this._filterString = value;
            }
        }

        public int BatchSize
        {
            get
            {
                return _batchSize;
            }
            set
            {
                __isset.batchSize = true;
                this._batchSize = value;
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

        public TAuthorization Authorizations
        {
            get
            {
                return _authorizations;
            }
            set
            {
                __isset.authorizations = true;
                this._authorizations = value;
            }
        }

        public bool Reversed
        {
            get
            {
                return _reversed;
            }
            set
            {
                __isset.reversed = true;
                this._reversed = value;
            }
        }

        public bool CacheBlocks
        {
            get
            {
                return _cacheBlocks;
            }
            set
            {
                __isset.cacheBlocks = true;
                this._cacheBlocks = value;
            }
        }

        public Dictionary<byte[], TTimeRange> ColFamTimeRangeMap
        {
            get
            {
                return _colFamTimeRangeMap;
            }
            set
            {
                __isset.colFamTimeRangeMap = true;
                this._colFamTimeRangeMap = value;
            }
        }

        /// <summary>
        /// 
        /// <seealso cref="TReadType"/>
        /// </summary>
        public TReadType ReadType
        {
            get
            {
                return _readType;
            }
            set
            {
                __isset.readType = true;
                this._readType = value;
            }
        }

        public int Limit
        {
            get
            {
                return _limit;
            }
            set
            {
                __isset.limit = true;
                this._limit = value;
            }
        }


        public Isset __isset;
        public struct Isset
        {
            public bool startRow;
            public bool stopRow;
            public bool columns;
            public bool caching;
            public bool maxVersions;
            public bool timeRange;
            public bool filterString;
            public bool batchSize;
            public bool attributes;
            public bool authorizations;
            public bool reversed;
            public bool cacheBlocks;
            public bool colFamTimeRangeMap;
            public bool readType;
            public bool limit;
        }

        public TScan()
        {
            this._maxVersions = 1;
            this.__isset.maxVersions = true;
        }

        public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
        {
            iprot.IncrementRecursionDepth();
            try
            {
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
                                StartRow = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 2:
                            if (field.Type == TType.String)
                            {
                                StopRow = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 3:
                            if (field.Type == TType.List)
                            {
                                {
                                    TList _list53 = await iprot.ReadListBeginAsync(cancellationToken);
                                    Columns = new List<TColumn>(_list53.Count);
                                    for (int _i54 = 0; _i54 < _list53.Count; ++_i54)
                                    {
                                        TColumn _elem55;
                                        _elem55 = new TColumn();
                                        await _elem55.ReadAsync(iprot, cancellationToken);
                                        Columns.Add(_elem55);
                                    }
                                    await iprot.ReadListEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 4:
                            if (field.Type == TType.I32)
                            {
                                Caching = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 5:
                            if (field.Type == TType.I32)
                            {
                                MaxVersions = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 6:
                            if (field.Type == TType.Struct)
                            {
                                TimeRange = new TTimeRange();
                                await TimeRange.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 7:
                            if (field.Type == TType.String)
                            {
                                FilterString = await iprot.ReadBinaryAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 8:
                            if (field.Type == TType.I32)
                            {
                                BatchSize = await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 9:
                            if (field.Type == TType.Map)
                            {
                                {
                                    TMap _map56 = await iprot.ReadMapBeginAsync(cancellationToken);
                                    Attributes = new Dictionary<byte[], byte[]>(_map56.Count);
                                    for (int _i57 = 0; _i57 < _map56.Count; ++_i57)
                                    {
                                        byte[] _key58;
                                        byte[] _val59;
                                        _key58 = await iprot.ReadBinaryAsync(cancellationToken);
                                        _val59 = await iprot.ReadBinaryAsync(cancellationToken);
                                        Attributes[_key58] = _val59;
                                    }
                                    await iprot.ReadMapEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 10:
                            if (field.Type == TType.Struct)
                            {
                                Authorizations = new TAuthorization();
                                await Authorizations.ReadAsync(iprot, cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 11:
                            if (field.Type == TType.Bool)
                            {
                                Reversed = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 12:
                            if (field.Type == TType.Bool)
                            {
                                CacheBlocks = await iprot.ReadBoolAsync(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 13:
                            if (field.Type == TType.Map)
                            {
                                {
                                    TMap _map60 = await iprot.ReadMapBeginAsync(cancellationToken);
                                    ColFamTimeRangeMap = new Dictionary<byte[], TTimeRange>(_map60.Count);
                                    for (int _i61 = 0; _i61 < _map60.Count; ++_i61)
                                    {
                                        byte[] _key62;
                                        TTimeRange _val63;
                                        _key62 = await iprot.ReadBinaryAsync(cancellationToken);
                                        _val63 = new TTimeRange();
                                        await _val63.ReadAsync(iprot, cancellationToken);
                                        ColFamTimeRangeMap[_key62] = _val63;
                                    }
                                    await iprot.ReadMapEndAsync(cancellationToken);
                                }
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 14:
                            if (field.Type == TType.I32)
                            {
                                ReadType = (TReadType)await iprot.ReadI32Async(cancellationToken);
                            }
                            else
                            {
                                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
                            }
                            break;
                        case 15:
                            if (field.Type == TType.I32)
                            {
                                Limit = await iprot.ReadI32Async(cancellationToken);
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
                var struc = new TStruct("TScan");
                await oprot.WriteStructBeginAsync(struc, cancellationToken);
                var field = new TField();
                if (StartRow != null && __isset.startRow)
                {
                    field.Name = "startRow";
                    field.Type = TType.String;
                    field.ID = 1;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(StartRow, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (StopRow != null && __isset.stopRow)
                {
                    field.Name = "stopRow";
                    field.Type = TType.String;
                    field.ID = 2;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(StopRow, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Columns != null && __isset.columns)
                {
                    field.Name = "columns";
                    field.Type = TType.List;
                    field.ID = 3;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteListBeginAsync(new TList(TType.Struct, Columns.Count), cancellationToken);
                        foreach (TColumn _iter64 in Columns)
                        {
                            await _iter64.WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteListEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.caching)
                {
                    field.Name = "caching";
                    field.Type = TType.I32;
                    field.ID = 4;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Caching, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.maxVersions)
                {
                    field.Name = "maxVersions";
                    field.Type = TType.I32;
                    field.ID = 5;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(MaxVersions, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (TimeRange != null && __isset.timeRange)
                {
                    field.Name = "timeRange";
                    field.Type = TType.Struct;
                    field.ID = 6;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await TimeRange.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (FilterString != null && __isset.filterString)
                {
                    field.Name = "filterString";
                    field.Type = TType.String;
                    field.ID = 7;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBinaryAsync(FilterString, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.batchSize)
                {
                    field.Name = "batchSize";
                    field.Type = TType.I32;
                    field.ID = 8;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(BatchSize, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Attributes != null && __isset.attributes)
                {
                    field.Name = "attributes";
                    field.Type = TType.Map;
                    field.ID = 9;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, Attributes.Count), cancellationToken);
                        foreach (byte[] _iter65 in Attributes.Keys)
                        {
                            await oprot.WriteBinaryAsync(_iter65, cancellationToken);
                            await oprot.WriteBinaryAsync(Attributes[_iter65], cancellationToken);
                        }
                        await oprot.WriteMapEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (Authorizations != null && __isset.authorizations)
                {
                    field.Name = "authorizations";
                    field.Type = TType.Struct;
                    field.ID = 10;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await Authorizations.WriteAsync(oprot, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.reversed)
                {
                    field.Name = "reversed";
                    field.Type = TType.Bool;
                    field.ID = 11;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(Reversed, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.cacheBlocks)
                {
                    field.Name = "cacheBlocks";
                    field.Type = TType.Bool;
                    field.ID = 12;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteBoolAsync(CacheBlocks, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (ColFamTimeRangeMap != null && __isset.colFamTimeRangeMap)
                {
                    field.Name = "colFamTimeRangeMap";
                    field.Type = TType.Map;
                    field.ID = 13;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    {
                        await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.Struct, ColFamTimeRangeMap.Count), cancellationToken);
                        foreach (byte[] _iter66 in ColFamTimeRangeMap.Keys)
                        {
                            await oprot.WriteBinaryAsync(_iter66, cancellationToken);
                            await ColFamTimeRangeMap[_iter66].WriteAsync(oprot, cancellationToken);
                        }
                        await oprot.WriteMapEndAsync(cancellationToken);
                    }
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.readType)
                {
                    field.Name = "readType";
                    field.Type = TType.I32;
                    field.ID = 14;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async((int)ReadType, cancellationToken);
                    await oprot.WriteFieldEndAsync(cancellationToken);
                }
                if (__isset.limit)
                {
                    field.Name = "limit";
                    field.Type = TType.I32;
                    field.ID = 15;
                    await oprot.WriteFieldBeginAsync(field, cancellationToken);
                    await oprot.WriteI32Async(Limit, cancellationToken);
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
            var other = that as TScan;
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ((__isset.startRow == other.__isset.startRow) && ((!__isset.startRow) || (TCollections.Equals(StartRow, other.StartRow))))
              && ((__isset.stopRow == other.__isset.stopRow) && ((!__isset.stopRow) || (TCollections.Equals(StopRow, other.StopRow))))
              && ((__isset.columns == other.__isset.columns) && ((!__isset.columns) || (TCollections.Equals(Columns, other.Columns))))
              && ((__isset.caching == other.__isset.caching) && ((!__isset.caching) || (System.Object.Equals(Caching, other.Caching))))
              && ((__isset.maxVersions == other.__isset.maxVersions) && ((!__isset.maxVersions) || (System.Object.Equals(MaxVersions, other.MaxVersions))))
              && ((__isset.timeRange == other.__isset.timeRange) && ((!__isset.timeRange) || (System.Object.Equals(TimeRange, other.TimeRange))))
              && ((__isset.filterString == other.__isset.filterString) && ((!__isset.filterString) || (TCollections.Equals(FilterString, other.FilterString))))
              && ((__isset.batchSize == other.__isset.batchSize) && ((!__isset.batchSize) || (System.Object.Equals(BatchSize, other.BatchSize))))
              && ((__isset.attributes == other.__isset.attributes) && ((!__isset.attributes) || (TCollections.Equals(Attributes, other.Attributes))))
              && ((__isset.authorizations == other.__isset.authorizations) && ((!__isset.authorizations) || (System.Object.Equals(Authorizations, other.Authorizations))))
              && ((__isset.reversed == other.__isset.reversed) && ((!__isset.reversed) || (System.Object.Equals(Reversed, other.Reversed))))
              && ((__isset.cacheBlocks == other.__isset.cacheBlocks) && ((!__isset.cacheBlocks) || (System.Object.Equals(CacheBlocks, other.CacheBlocks))))
              && ((__isset.colFamTimeRangeMap == other.__isset.colFamTimeRangeMap) && ((!__isset.colFamTimeRangeMap) || (TCollections.Equals(ColFamTimeRangeMap, other.ColFamTimeRangeMap))))
              && ((__isset.readType == other.__isset.readType) && ((!__isset.readType) || (System.Object.Equals(ReadType, other.ReadType))))
              && ((__isset.limit == other.__isset.limit) && ((!__isset.limit) || (System.Object.Equals(Limit, other.Limit))));
        }

        public override int GetHashCode()
        {
            int hashcode = 157;
            unchecked
            {
                if (__isset.startRow)
                    hashcode = (hashcode * 397) + StartRow.GetHashCode();
                if (__isset.stopRow)
                    hashcode = (hashcode * 397) + StopRow.GetHashCode();
                if (__isset.columns)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Columns);
                if (__isset.caching)
                    hashcode = (hashcode * 397) + Caching.GetHashCode();
                if (__isset.maxVersions)
                    hashcode = (hashcode * 397) + MaxVersions.GetHashCode();
                if (__isset.timeRange)
                    hashcode = (hashcode * 397) + TimeRange.GetHashCode();
                if (__isset.filterString)
                    hashcode = (hashcode * 397) + FilterString.GetHashCode();
                if (__isset.batchSize)
                    hashcode = (hashcode * 397) + BatchSize.GetHashCode();
                if (__isset.attributes)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(Attributes);
                if (__isset.authorizations)
                    hashcode = (hashcode * 397) + Authorizations.GetHashCode();
                if (__isset.reversed)
                    hashcode = (hashcode * 397) + Reversed.GetHashCode();
                if (__isset.cacheBlocks)
                    hashcode = (hashcode * 397) + CacheBlocks.GetHashCode();
                if (__isset.colFamTimeRangeMap)
                    hashcode = (hashcode * 397) + TCollections.GetHashCode(ColFamTimeRangeMap);
                if (__isset.readType)
                    hashcode = (hashcode * 397) + ReadType.GetHashCode();
                if (__isset.limit)
                    hashcode = (hashcode * 397) + Limit.GetHashCode();
            }
            return hashcode;
        }

        public override string ToString()
        {
            var sb = new StringBuilder("TScan(");
            bool __first = true;
            if (StartRow != null && __isset.startRow)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("StartRow: ");
                sb.Append(StartRow);
            }
            if (StopRow != null && __isset.stopRow)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("StopRow: ");
                sb.Append(StopRow);
            }
            if (Columns != null && __isset.columns)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Columns: ");
                sb.Append(Columns);
            }
            if (__isset.caching)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Caching: ");
                sb.Append(Caching);
            }
            if (__isset.maxVersions)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("MaxVersions: ");
                sb.Append(MaxVersions);
            }
            if (TimeRange != null && __isset.timeRange)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("TimeRange: ");
                sb.Append(TimeRange == null ? "<null>" : TimeRange.ToString());
            }
            if (FilterString != null && __isset.filterString)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("FilterString: ");
                sb.Append(FilterString);
            }
            if (__isset.batchSize)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("BatchSize: ");
                sb.Append(BatchSize);
            }
            if (Attributes != null && __isset.attributes)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Attributes: ");
                sb.Append(Attributes);
            }
            if (Authorizations != null && __isset.authorizations)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Authorizations: ");
                sb.Append(Authorizations == null ? "<null>" : Authorizations.ToString());
            }
            if (__isset.reversed)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Reversed: ");
                sb.Append(Reversed);
            }
            if (__isset.cacheBlocks)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("CacheBlocks: ");
                sb.Append(CacheBlocks);
            }
            if (ColFamTimeRangeMap != null && __isset.colFamTimeRangeMap)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("ColFamTimeRangeMap: ");
                sb.Append(ColFamTimeRangeMap);
            }
            if (__isset.readType)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("ReadType: ");
                sb.Append(ReadType);
            }
            if (__isset.limit)
            {
                if (!__first) { sb.Append(", "); }
                __first = false;
                sb.Append("Limit: ");
                sb.Append(Limit);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }

}
