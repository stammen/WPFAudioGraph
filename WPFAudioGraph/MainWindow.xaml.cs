//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAudioGraph
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VoiceAgent.AudioInput m_audioInput;
        private VoiceAgent.AudioOutput m_audioOutput;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (m_audioInput != null)
            {
                m_audioInput.Stop();
                m_audioInput.OnAudioInput -= OnAudioInput;
                m_audioInput = null;
            }

            if (m_audioOutput != null)
            {
                m_audioOutput.Stop();
                m_audioOutput.OnAudioComplete -= OnAudioComplete;
                m_audioOutput = null;
            }

            m_audioInput = new VoiceAgent.AudioInput();
            m_audioInput.OnAudioInput += OnAudioInput;
            m_audioOutput = new VoiceAgent.AudioOutput();
            m_audioOutput.OnAudioComplete += OnAudioComplete;
            await m_audioOutput.Start();
            await m_audioInput.Start();
        }

        private void OnAudioInput(IWaveBuffer waveBuffer)
        {
            try
            {
                m_audioOutput.Send(waveBuffer.ByteBuffer);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void OnAudioComplete()
        {
            Debug.WriteLine("OnAudioComplete");
        }
    }
}
