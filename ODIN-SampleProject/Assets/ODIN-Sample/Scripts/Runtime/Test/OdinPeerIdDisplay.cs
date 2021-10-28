using System;
using System.Text;
using OdinNative.Odin.Peer;
using OdinNative.Odin.Room;
using UnityEngine;
using UnityEngine.UI;

namespace ODIN_Sample.Scripts.Runtime.Test
{
    public class OdinPeerIdDisplay : MonoBehaviour
    {
        [SerializeField] private Text display;
        
        private StringBuilder displayBuilder = new StringBuilder();

        // Update is called once per frame
        void Update()
        {
            if (OdinHandler.Instance)
            {
                foreach (Room room in OdinHandler.Instance.Rooms)
                {
                    foreach (Peer peer in room.RemotePeers)
                    {
                        if (peer.Id == room.Self.Id)
                        {
                            displayBuilder.AppendLine($"Room: {room.Config.Name}, Self peer Id: {peer.Id}");
                        }
                        else
                        {
                            displayBuilder.AppendLine($"Room: {room.Config.Name}, Remote peer Id: {peer.Id}");
                        }
                    }

                    if (null != room.MicrophoneMedia)
                    {
                        int micMediaId = room.MicrophoneMedia.Id;
                        Peer microphoneMediaOwner = default;
                        foreach (Peer peer in room.RemotePeers)
                        {
                            if (peer.Medias.Contains(micMediaId))
                            {
                                microphoneMediaOwner = peer;
                            }
                        }

                        if (null != microphoneMediaOwner)
                        {
                            displayBuilder.AppendLine($"Room: {room.Config.Name}, Microphone Id: {room.MicrophoneMedia.Id}, Owner: {microphoneMediaOwner.Id}");
                        }
                    }
                    
                }
            }
            display.text = displayBuilder.ToString();
            displayBuilder.Clear();
        }
    }
}