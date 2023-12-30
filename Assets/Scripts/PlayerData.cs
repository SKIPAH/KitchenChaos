using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

public struct PlayerData : IEquatable<PlayerData>, INetworkSerializable
{

    public ulong clientId;
    public int colorId;
    //cant use normal string in this sitaution
    public FixedString64Bytes playerName;

    public bool Equals(PlayerData other)
    {
        return 
            clientId == other.clientId &&
            colorId == other.colorId &&
            playerName == other.playerName;
    }

    public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
    {
        serializer.SerializeValue(ref clientId);
        serializer.SerializeValue(ref colorId);
        serializer.SerializeValue(ref playerName);
    }
}

   


