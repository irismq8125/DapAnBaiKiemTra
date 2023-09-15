namespace kiemtra.Models
{
    public class HomeProduct
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public double GiamGia { get; set; }
        public int TamTinh { get; set; }
        public HomeProduct() { }
        public HomeProduct(string tenSanPham, int soLuong, int gia, double tyle)
        {
            TenSanPham = tenSanPham;
            SoLuong = soLuong;
            DonGia = gia;
            GiamGia = (soLuong * gia) * (tyle / 100);
            TamTinh = soLuong * gia;
        }
    }
}
