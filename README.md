# ⚽ RefereeX - Antalya ASKF Hakem ve İdman Otomasyon Sistemi

RefereeX, Antalya Amatör Spor Kulüpleri Federasyonu (ASKF) bünyesindeki futbol hakemlerinin idman katılım süreçlerini, imza kayıtlarını ve klasman bilgilerini takip ederek, müsabakalara adil ve performans odaklı maç ataması gerçekleştiren modern bir **Masaüstü (Windows Forms)** otomasyon sistemidir.

Proje, ilişkisel veri tabanı tasarımı kurallarına (3NF) tam uyumlu bir altyapıya ve Entity Framework Core teknolojisine dayanmaktadır.

---

## 🛠️ Teknolojik Altyapı

* **Framework:** .NET 8.0 (Long-Term Support)
* **ORM (Veri Tabanı Katmanı):** Entity Framework Core 8.0
* **Database Management:** Microsoft SQL Server (MS-SQL)
* **Design Pattern:** Bağımsız DbContext ve Katmanlı Servis Mimarisi (Service Layer Pattern)

---

## 📐 Veri Tabanı Mimarisi (3. Normal Form)

Proje, metinsel karmaşıklığı önlemek ve veri tekrarını engellemek amacıyla **4 bağımsız ilişkisel tablodan** oluşmaktadır. 

### Veri Modeli ve İlişkiler (UML Sınıf Diyagramı)

```text
+------------------------+
|          Rank          |
+------------------------+
| + Id: int              |
| + RankName: string     |
| + Referees: ICollection|
+------------------------+
            | 1
            |
            | M
      +-----------------------------------------------+
      |                    Referee                    |
      +-----------------------------------------------+
      | + Id: int                                     |
      | + FirstName: string                           |
      | + LastName: string                            |
      | + Rank_Id: int                                |
      | + IsActive: bool                              |
      | + Rank: Rank                                  |
      | + TrainingAttendances: ICollection            |
      +-----------------------------------------------+
            | 1                                 | 1
            |                                   |
            | M                                 | M
      +--------------------+      +-----------------------------------------------+
      |        Match       |      |               TrainingAttendance              |
      +--------------------+      +-----------------------------------------------+
      | + Id: int          |      | + Id: int                                     |
      | + MatchName: string|      | + Referee_Id: int                             |
      | + MatchDate: Datetime|    | + Training_Id: int                            |
      | + AssignedRef_Id:int?|    | + IsSignedTime: DateTime                      |
      | + AssignedRef:Ref  |      | + IsPresent: bool                             |
      +--------------------+      | + Referee: Referee                            |
                                  | + Training: Training                          |
                                  +-----------------------------------------------+
                                                        | M
                                                        |
                                                        | 1
                                            +------------------------+
                                            |        Training        |
                                            +------------------------+
                                            | + Id: int              |
                                            | + TrainingDate: DateTime|
                                            | + Location: string     |
                                            | + TrainingAttendances: |
                                            +------------------------+
