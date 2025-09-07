/*
DS4Windows
Copyright (C) 2023  Travis Nickles

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using System.Xml;
using System.Xml.Serialization;
using DS4Windows;

namespace DS4WinWPF.DS4Control.DTOXml
{
    [XmlRoot(DS4ControllerOptions.XML_ELEMENT_NAME)]
    public class DS4ControllerOptsDTO : IDTO<DS4ControllerOptions>
    {
        [XmlElement("Copycat")]
        public string IsCopyCatString
        {
            get => IsCopyCat.ToString();
            set
            {
                IsCopyCat = XmlDataUtilities.StrToBool(value);
            }
        }

        [XmlIgnore]
        public bool IsCopyCat
        {
            get; set;
        }

        [XmlElement("ForceGyroAxisFixup")]
        public string ForceGyroAxisFixupString
        {
            get => ForceGyroAxisFixup.ToString();
            set => ForceGyroAxisFixup = XmlDataUtilities.StrToBool(value);
        }

        [XmlIgnore]
        public bool ForceGyroAxisFixup
        {
            get; set;
        } = true;

        [XmlElement("EnableGyroYawOffset")]
        public string EnableGyroYawOffsetString
        {
            get => EnableGyroYawOffset.ToString();
            set => EnableGyroYawOffset = XmlDataUtilities.StrToBool(value);
        }

        [XmlIgnore]
        public bool EnableGyroYawOffset
        {
            get; set;
        }

        [XmlElement("GyroYawOffset")]
        public int GyroYawOffset
        {
            get; set;
        }

        [XmlElement("EnableGyroPitchOffset")]
        public string EnableGyroPitchOffsetString
        {
            get => EnableGyroPitchOffset.ToString();
            set => EnableGyroPitchOffset = XmlDataUtilities.StrToBool(value);
        }

        [XmlIgnore]
        public bool EnableGyroPitchOffset
        {
            get; set;
        }

        [XmlElement("GyroPitchOffset")]
        public int GyroPitchOffset
        {
            get; set;
        }

        [XmlElement("EnableGyroRollOffset")]
        public string EnableGyroRollOffsetString
        {
            get => EnableGyroRollOffset.ToString();
            set => EnableGyroRollOffset = XmlDataUtilities.StrToBool(value);
        }

        [XmlIgnore]
        public bool EnableGyroRollOffset
        {
            get; set;
        }

        [XmlElement("GyroRollOffset")]
        public int GyroRollOffset
        {
            get; set;
        }

        public void MapFrom(DS4ControllerOptions source)
        {
            IsCopyCat = source.IsCopyCat;
            ForceGyroAxisFixup = source.ForceGyroAxisFixup;
            EnableGyroYawOffset = source.EnableGyroYawOffset;
            GyroYawOffset = source.GyroYawOffset;
            EnableGyroPitchOffset = source.EnableGyroPitchOffset;
            GyroPitchOffset = source.GyroPitchOffset;
            EnableGyroRollOffset = source.EnableGyroRollOffset;
            GyroRollOffset = source.GyroRollOffset;
        }

        public void MapTo(DS4ControllerOptions destination)
        {
            destination.IsCopyCat = IsCopyCat;
            destination.ForceGyroAxisFixup = ForceGyroAxisFixup;
            destination.EnableGyroYawOffset = EnableGyroYawOffset;
            destination.GyroYawOffset = GyroYawOffset;
            destination.EnableGyroPitchOffset = EnableGyroPitchOffset;
            destination.GyroPitchOffset = GyroPitchOffset;
            destination.EnableGyroRollOffset = EnableGyroRollOffset;
            destination.GyroRollOffset = GyroRollOffset;
        }
    }
}
