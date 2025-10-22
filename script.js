// === SCRIPT WEBSITE AGRIBISNIS ===

// 🌙 Mode Gelap
const themeBtn = document.getElementById('theme-toggle');
if (localStorage.getItem('theme') === 'dark') {
  document.body.classList.add('dark');
  if (themeBtn) themeBtn.textContent = '☀️';
}
if (themeBtn) {
  themeBtn.addEventListener('click', () => {
    document.body.classList.toggle('dark');
    if (document.body.classList.contains('dark')) {
      themeBtn.textContent = '☀️';
      localStorage.setItem('theme', 'dark');
    } else {
      themeBtn.textContent = '🌙';
      localStorage.setItem('theme', 'light');
    }
  });
}

// 🌾 Parallax Background
window.addEventListener("scroll", () => {
  const banner = document.querySelector(".banner");
  if (banner) {
    const scrollY = window.scrollY;
    banner.style.backgroundPositionY = -(scrollY * 0.3) + "px";
  }
});

// 🎬 Animasi Muncul Saat Scroll
function revealOnScroll() {
  const fadeItems = document.querySelectorAll('.card, .fade-up, .tabel-kurikulum, .galeri-grid, .form-kontak');
  fadeItems.forEach(el => {
    const top = el.getBoundingClientRect().top;
    const vh = window.innerHeight;
    if (top < vh - 100) el.classList.add('fade-active');
  });
}
window.addEventListener('scroll', revealOnScroll);
window.addEventListener('load', revealOnScroll);

// 🌟 Transisi Antar Halaman
document.addEventListener("DOMContentLoaded", () => {
  document.body.classList.add("loaded");
});
document.querySelectorAll("a").forEach(link => {
  const url = link.getAttribute("href");
  if (url && !url.startsWith("#") && !url.startsWith("mailto")) {
    link.addEventListener("click", e => {
      e.preventDefault();
      document.body.classList.remove("loaded");
      setTimeout(() => window.location.href = url, 400);
    });
  }
});

// 📬 Form Kontak
const form = document.querySelector('.form-kontak');
if (form) {
  form.addEventListener('submit', e => {
    e.preventDefault();
    alert('Terima kasih! Pesan Anda telah dikirim. (Demo form)');
    form.reset();
  });
}