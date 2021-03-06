/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace Mflex.Thrift
{
    /// <summary>
    /// Specify Durability:
    ///  - SKIP_WAL means do not write the Mutation to the WAL.
    ///  - ASYNC_WAL means write the Mutation to the WAL asynchronously,
    ///  - SYNC_WAL means write the Mutation to the WAL synchronously,
    ///  - FSYNC_WAL means Write the Mutation to the WAL synchronously and force the entries to disk.
    /// </summary>
    public enum TDurability
    {
        SKIP_WAL = 1,
        ASYNC_WAL = 2,
        SYNC_WAL = 3,
        FSYNC_WAL = 4,
    }
}
