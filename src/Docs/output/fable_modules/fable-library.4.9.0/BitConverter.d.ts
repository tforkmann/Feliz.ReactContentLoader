import { uint8, int16, uint16, int32, uint32, float32, float64 } from "./Int32.js";
import { int64, uint64 } from "./BigInt.js";
import { char } from "./Char.js";
export declare function isLittleEndian(): boolean;
export declare function getBytesBoolean(value: boolean): Uint8Array;
export declare function getBytesChar(value: char): Uint8Array;
export declare function getBytesInt16(value: int16): Uint8Array;
export declare function getBytesInt32(value: int32): Uint8Array;
export declare function getBytesInt64(value: int64): Uint8Array;
export declare function getBytesUInt16(value: uint16): Uint8Array;
export declare function getBytesUInt32(value: uint32): Uint8Array;
export declare function getBytesUInt64(value: uint64): Uint8Array;
export declare function getBytesSingle(value: float32): Uint8Array;
export declare function getBytesDouble(value: float64): Uint8Array;
export declare function int64BitsToDouble(value: int64): float64;
export declare function doubleToInt64Bits(value: float64): int64;
export declare function toBoolean(bytes: ArrayLike<uint8>, offset: int32): boolean;
export declare function toChar(bytes: ArrayLike<uint8>, offset: int32): char;
export declare function toInt16(bytes: ArrayLike<uint8>, offset: int32): int16;
export declare function toInt32(bytes: ArrayLike<uint8>, offset: int32): int32;
export declare function toInt64(bytes: ArrayLike<uint8>, offset: int32): int64;
export declare function toUInt16(bytes: ArrayLike<uint8>, offset: int32): uint16;
export declare function toUInt32(bytes: ArrayLike<uint8>, offset: int32): uint32;
export declare function toUInt64(bytes: ArrayLike<uint8>, offset: int32): uint64;
export declare function toSingle(bytes: ArrayLike<uint8>, offset: int32): float32;
export declare function toDouble(bytes: ArrayLike<uint8>, offset: int32): float64;
export declare function toString(bytes: ArrayLike<uint8>, offset?: int32, count?: int32): string;
