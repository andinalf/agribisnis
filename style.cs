/* === STYLE WEBSITE AGRIBISNIS === */

/* Font */
@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;600&family=Merriweather:wght@700&display=swap');

:root {
  --navy: #0a1a3f;
  --navy-light: #1f3b7a;
  --gold: #c9a43a;
  --white: #ffffff;
  --soft-blue: #f4f7ff;
}

/* Reset */
* {
  box-sizing: border-box;
  scroll-behavior: smooth;
}

body {
  margin: 0;
  font-family: 'Poppins', sans-serif;
  background: var(--soft-blue);
  color: #1f2937;
  opacity: 0;
  transition: opacity 0.8s ease;
}

body.loaded {
  opacity: 1;
}

/* Header */
.site-header {
  background: linear-gradient(90deg, var(--navy), var(--navy-light));
  color: var(--white);
  padding: 12px 0;
  box-shadow: 0 3px 10px rgba(0,0,0,0.25);
  position: sticky;
  top: 0;
  z-index: 1000;
}

.header-inner {
  max-width: 1200px;
  margin: 0 auto;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 0 20px;
}

.brand {
  display: flex;
  align-items: center;
  gap: 15px;
}

.logo img {
  height: 60px;
}

.site-title h1 {
  font-family: 'Merriweather', serif;
  font-size: 20px;
  margin: 0;
}

/* Nav */
.site-nav ul {
  list-style: none;
  display: flex;
  gap: 20px;
  margin: 0;
  padding: 0;
}

.site-nav a {
  color: white;
  text-decoration: none;
  position: relative;
  transition: 0.3s;
}

.site-nav a::after {
  content: "";
  position: absolute;
  bottom: -3px;
  left: 0;
  width: 0%;
  height: 2px;
  background: var(--gold);
  transition: 0.3s ease;
}

.site-nav a:hover::after {
  width: 100%;
}

/* Tombol */
.theme-btn {
  background: transparent;
  color: white;
  font-size: 18px;
  border: none;
  cursor: pointer;
}

/* Banner */
.banner {
  position: relative;
  height: 450px;
  background: linear-gradient(120deg, rgba(8,26,63,0.7), rgba(30,58,138,0.6)),
              url("images/sawah.jpg") center/cover no-repeat fixed;
  color: white;
  display: flex;
  align-items: center;
  justify-content: center;
  text-align: left;
  background-attachment: fixed;
  transition: background-position 0.2s ease-out;
}

.banner-inner {
  max-width: 900px;
  padding: 20px;
}

.banner h2 {
  font-family: 'Merriweather', serif;
  font-size: 2.2rem;
  margin-bottom: 10px;
}

.banner p {
  font-size: 1.1rem;
  color: #eef1ff;
  margin-bottom: 20px;
}

.banner-buttons {
  display: flex;
  gap: 12px;
}

.btn {
  padding: 10px 18px;
  border-radius: 8px;
  font-weight: 600;
  text-decoration: none;
  transition: 0.3s;
}

.btn-primary {
  background: var(--gold);
  color: var(--navy);
}

.btn-primary:hover {
  box-shadow: 0 0 15px rgba(255, 215, 0, 0.6);
  transform: translateY(-3px);
}

.btn-outline {
  border: 2px solid #fff;
  color: #fff;
}

.btn-outline:hover {
  background: rgba(255,255,255,0.1);
}

/* Kontainer Umum */
.container {
  max-width: 1100px;
  margin: 0 auto;
  padding: 50px 20px;
}

/* Kartu */
.card {card {
  background: rgba(255, 255, 255, 0.75); /* transparan putih susu */
  border-radius: 15px;
  padding: 25px;
  margin-bottom: 25px;
  box-shadow: 0 8px 25px rgba(0,0,0,0.15);
  border-left: 5px solid #c9a43a; /* emas elegan */
  transition: all 0.6s ease;
  backdrop-filter: blur(8px); /* efek kaca buram */
}

.card.left { transform: translateX(-50px); }
.card.right { transform: translateX(50px); }
.card.fade-up { transform: translateY(40px); }

.card.active,
.fade-active {
  opacity: 1;
  transform: translate(0,0);
  animation: fadeUp 1s ease;
}

.card h3 {
  font-family: 'Merriweather', serif;
  color: var(--navy);
  margin-top: 0;
}

/* Footer */
.site-footer {
  background: linear-gradient(90deg, var(--navy), var(--navy-light));
  color: white;
  text-align: center;
  padding: 20px;
}

/* PROFIL DOSEN */
.dosen-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(220px, 1fr));
  gap: 24px;
  margin-top: 20px;
}

.dosen-card {
  background: #fff;
  border-radius: 12px;
  box-shadow: 0 8px 20px rgba(0,0,0,0.08);
  padding: 16px;
  text-align: center;
  transition: transform 0.3s ease, box-shadow 0.3s ease;
  border-top: 4px solid var(--gold);
}

.dosen-card img {
  width: 100%;
  height: 220px;
  object-fit: cover;
  border-radius: 10px;
  margin-bottom: 10px;
}

.dosen-card:hover {
  transform: translateY(-6px);
  box-shadow: 0 12px 28px rgba(0,0,0,0.12);
}

/* Tabel Kurikulum */
.tabel-kurikulum {
  width: 100%;
  border-collapse: collapse;
  margin-top: 20px;
  box-shadow: 0 4px 20px rgba(0,0,0,0.08);
  border-radius: 10px;
  overflow: hidden;
}

.tabel-kurikulum th {
  background: var(--navy-light);
  color: #fff;
  text-align: left;
  padding: 12px;
  font-weight: 600;
  font-size: 0.95rem;
}

.tabel-kurikulum td {
  padding: 12px;
  border-bottom: 1px solid #e5e7eb;
  color: #1f2937;
}

.tabel-kurikulum tr:hover {
  background: #eef4ff;
  transition: 0.3s;
}

/* Galeri */
.galeri-grid {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
  gap: 20px;
  margin-top: 16px;
}

.galeri-item {
  border: 6px solid #fff;
  border-radius: 12px;
  overflow: hidden;
  box-shadow: 0 8px 20px rgba(0,0,0,0.1);
  transition: transform 0.4s ease, box-shadow 0.4s ease;
}

.galeri-item img {
  width: 100%;
  height: 200px;
  object-fit: cover;
  display: block;
}

.galeri-item:hover {
  transform: scale(1.05);
  box-shadow: 0 12px 30px rgba(0,0,0,0.2);
  border-color: var(--gold);
}

/* Form Kontak */
.form-kontak {
  display: flex;
  flex-direction: column;
  gap: 10px;
}

.form-kontak label {
  font-weight: 600;
  color: var(--navy);
}

.form-kontak input,
.form-kontak textarea {
  padding: 10px;
  border-radius: 6px;
  border: 1px solid #cbd5e1;
  font-size: 1rem;
  resize: none;
  font-family: 'Poppins', sans-serif;
}

.form-kontak input:focus,
.form-kontak textarea:focus {
  outline: none;
  border-color: var(--gold);
  box-shadow: 0 0 5px rgba(201,164,58,0.3);
}

/* Animasi */
@keyframes fadeUp {
  0% { opacity: 0; transform: translateY(50px); }
  100% { opacity: 1; transform: translateY(0); }
}

/* Mode Gelap */
body.dark {
  background: #0a0f25;
  color: #dbe3ff;
}
body.dark .card {
  background: #111a35;
  color: #dbe3ff;
}