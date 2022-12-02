using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDBH.DAO
{
    public class BH_TraCuuThe
    {
        [JsonProperty("maKetQua")]
        public string MaKetQua { get; set; }

        [JsonProperty("ghiChu")]
        public string GhiChu { get; set; }

        [JsonProperty("maThe")]
        public string MaThe { get; set; }

        [JsonProperty("hoTen")]
        public string HoTen { get; set; }

        [JsonProperty("ngaySinh")]
        public string NgaySinh { get; set; }

        [JsonProperty("gioiTinh")]
        public string GioiTinh { get; set; }

        [JsonProperty("diaChi")]
        public string DiaChi { get; set; }

        [JsonProperty("maDKBD")]
        public string MaDKBD { get; set; }

        [JsonProperty("cqBHXH")]
        public string CqBHXH { get; set; }

        [JsonProperty("gtTheTu")]
        public string GtTheTu { get; set; }

        [JsonProperty("gtTheDen")]
        public string GtTheDen { get; set; }

        [JsonProperty("maKV")]
        public string MaKV { get; set; }

        [JsonProperty("ngayDu5Nam")]
        public string NgayDu5Nam { get; set; }

        [JsonProperty("maSoBHXH")]
        public string MaSoBHXH { get; set; }

        [JsonProperty("maTheCu")]
        public object MaTheCu { get; set; }

        [JsonProperty("maTheMoi")]
        public string MaTheMoi { get; set; }

        [JsonProperty("gtTheTuMoi")]
        public string GtTheTuMoi { get; set; }

        [JsonProperty("gtTheDenMoi")]
        public string GtTheDenMoi { get; set; }

        [JsonProperty("maDKBDMoi")]
        public string MaDKBDMoi { get; set; }

        [JsonProperty("tenDKBDMoi")]
        public string TenDKBDMoi { get; set; }

        [JsonProperty("dsLichSuKCB2018")]
        public List<DsLichSuKCB2018> DsLichSuKCB2018 { get; set; }

        [JsonProperty("dsLichSuKT2018")]
        public List<object> DsLichSuKT2018 { get; set; }
    }
    public class DsLichSuKCB2018
    {
        [JsonProperty("maHoSo")]
        public string MaHoSo { get; set; }

        [JsonProperty("maCSKCB")]
        public string MaCSKCB { get; set; }

        [JsonProperty("ngayVao")]
        public string NgayVao { get; set; }

        [JsonProperty("ngayRa")]
        public string NgayRa { get; set; }

        [JsonProperty("tenBenh")]
        public string TenBenh { get; set; }

        [JsonProperty("tinhTrang")]
        public string TinhTrang { get; set; }

        [JsonProperty("kqDieuTri")]
        public string KqDieuTri { get; set; }
    }


}
