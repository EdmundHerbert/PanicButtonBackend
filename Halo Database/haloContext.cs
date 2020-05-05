using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PanicButtonBackend
{
    public partial class haloContext : DbContext
    {
        public haloContext()
        {
        }

        public haloContext(DbContextOptions<haloContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Apilogger> Apilogger { get; set; }
        public virtual DbSet<Applicationdistributions> Applicationdistributions { get; set; }
        public virtual DbSet<ArcherDeliveryReport> ArcherDeliveryReport { get; set; }
        public virtual DbSet<ArchiveHaloclientmembers> ArchiveHaloclientmembers { get; set; }
        public virtual DbSet<ArchiveHaloinappregistration> ArchiveHaloinappregistration { get; set; }
        public virtual DbSet<ArchiveHalomemberprograms> ArchiveHalomemberprograms { get; set; }
        public virtual DbSet<ArchiveHalomembers> ArchiveHalomembers { get; set; }
        public virtual DbSet<ArchiveHalophonenumbers> ArchiveHalophonenumbers { get; set; }
        public virtual DbSet<ArchiveHalovehiclelicences> ArchiveHalovehiclelicences { get; set; }
        public virtual DbSet<Authtokens> Authtokens { get; set; }
        public virtual DbSet<BrokerUser> BrokerUser { get; set; }
        public virtual DbSet<Callcentreaudittrail> Callcentreaudittrail { get; set; }
        public virtual DbSet<Callcentrechatmessages> Callcentrechatmessages { get; set; }
        public virtual DbSet<Callcentrefaqs> Callcentrefaqs { get; set; }
        public virtual DbSet<Callcentrefirestations> Callcentrefirestations { get; set; }
        public virtual DbSet<Callcentremodules> Callcentremodules { get; set; }
        public virtual DbSet<Callcentrerolemodules> Callcentrerolemodules { get; set; }
        public virtual DbSet<Callcentreuserroles> Callcentreuserroles { get; set; }
        public virtual DbSet<Callcentreusers> Callcentreusers { get; set; }
        public virtual DbSet<Cartrack> Cartrack { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<CitiesList> CitiesList { get; set; }
        public virtual DbSet<ClientTokens> ClientTokens { get; set; }
        public virtual DbSet<Cmsmodules> Cmsmodules { get; set; }
        public virtual DbSet<Cmsrolemodules> Cmsrolemodules { get; set; }
        public virtual DbSet<Cmsuserroles> Cmsuserroles { get; set; }
        public virtual DbSet<Cmsusers> Cmsusers { get; set; }
        public virtual DbSet<Communicationlog> Communicationlog { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryList> CountryList { get; set; }
        public virtual DbSet<EdmundsTest> EdmundsTest { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<FnolCity> FnolCity { get; set; }
        public virtual DbSet<FnolClaim> FnolClaim { get; set; }
        public virtual DbSet<FnolCountry> FnolCountry { get; set; }
        public virtual DbSet<FnolDocument> FnolDocument { get; set; }
        public virtual DbSet<FnolStateprovince> FnolStateprovince { get; set; }
        public virtual DbSet<FnolSuburb> FnolSuburb { get; set; }
        public virtual DbSet<HaloMobileContentClients> HaloMobileContentClients { get; set; }
        public virtual DbSet<Haloaudittrail> Haloaudittrail { get; set; }
        public virtual DbSet<Halobatchimported> Halobatchimported { get; set; }
        public virtual DbSet<Halobranches> Halobranches { get; set; }
        public virtual DbSet<Halochatmessages> Halochatmessages { get; set; }
        public virtual DbSet<Halochatrequests> Halochatrequests { get; set; }
        public virtual DbSet<Haloclaims> Haloclaims { get; set; }
        public virtual DbSet<Haloclaimtypes> Haloclaimtypes { get; set; }
        public virtual DbSet<Haloclientapiregister> Haloclientapiregister { get; set; }
        public virtual DbSet<Haloclientbanners> Haloclientbanners { get; set; }
        public virtual DbSet<Haloclientmembers> Haloclientmembers { get; set; }
        public virtual DbSet<Haloclientpartners> Haloclientpartners { get; set; }
        public virtual DbSet<Haloclientprogramproducts> Haloclientprogramproducts { get; set; }
        public virtual DbSet<Haloclientprograms> Haloclientprograms { get; set; }
        public virtual DbSet<Haloclients> Haloclients { get; set; }
        public virtual DbSet<Haloclientslogin> Haloclientslogin { get; set; }
        public virtual DbSet<HalodictionaryEnZa> HalodictionaryEnZa { get; set; }
        public virtual DbSet<Halodriverslicences> Halodriverslicences { get; set; }
        public virtual DbSet<Halofasttrackclaims> Halofasttrackclaims { get; set; }
        public virtual DbSet<Halofrontlinephone> Halofrontlinephone { get; set; }
        public virtual DbSet<Haloftpaudittrail> Haloftpaudittrail { get; set; }
        public virtual DbSet<Haloinappapplications> Haloinappapplications { get; set; }
        public virtual DbSet<Haloinappmessages> Haloinappmessages { get; set; }
        public virtual DbSet<Haloinappregistration> Haloinappregistration { get; set; }
        public virtual DbSet<HalomemberAdditionalClientData> HalomemberAdditionalClientData { get; set; }
        public virtual DbSet<Halomemberclaims> Halomemberclaims { get; set; }
        public virtual DbSet<Halomemberclaimseyewitness> Halomemberclaimseyewitness { get; set; }
        public virtual DbSet<Halomemberclaimsthirdparty> Halomemberclaimsthirdparty { get; set; }
        public virtual DbSet<Halomemberdependants> Halomemberdependants { get; set; }
        public virtual DbSet<Halomemberftpfiles> Halomemberftpfiles { get; set; }
        public virtual DbSet<Halomemberidtialpolicyinfo> Halomemberidtialpolicyinfo { get; set; }
        public virtual DbSet<Halomemberloaderror> Halomemberloaderror { get; set; }
        public virtual DbSet<Halomembermessages> Halomembermessages { get; set; }
        public virtual DbSet<Halomemberphonenumbers> Halomemberphonenumbers { get; set; }
        public virtual DbSet<Halomemberprograms> Halomemberprograms { get; set; }
        public virtual DbSet<Halomembers> Halomembers { get; set; }
        public virtual DbSet<Halomembersstage> Halomembersstage { get; set; }
        public virtual DbSet<Halomobileclientcontent> Halomobileclientcontent { get; set; }
        public virtual DbSet<Halomobilecontent> Halomobilecontent { get; set; }
        public virtual DbSet<Halonetstar> Halonetstar { get; set; }
        public virtual DbSet<Halopanics> Halopanics { get; set; }
        public virtual DbSet<Halopartners> Halopartners { get; set; }
        public virtual DbSet<Haloproducts> Haloproducts { get; set; }
        public virtual DbSet<Haloreminders> Haloreminders { get; set; }
        public virtual DbSet<Halosentsmss> Halosentsmss { get; set; }
        public virtual DbSet<Halositeconfig> Halositeconfig { get; set; }
        public virtual DbSet<Halovehiclelicences> Halovehiclelicences { get; set; }
        public virtual DbSet<Halovehiclemonitorintegration> Halovehiclemonitorintegration { get; set; }
        public virtual DbSet<Inappnotificationclientdetails> Inappnotificationclientdetails { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Otplogin> Otplogin { get; set; }
        public virtual DbSet<Policychangerequests> Policychangerequests { get; set; }
        public virtual DbSet<Policytestids> Policytestids { get; set; }
        public virtual DbSet<ProductIcons> ProductIcons { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<ProvincesList> ProvincesList { get; set; }
        public virtual DbSet<ReferenceSubset> ReferenceSubset { get; set; }
        public virtual DbSet<ReferralResponse> ReferralResponse { get; set; }
        public virtual DbSet<Referrals> Referrals { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionList> RegionList { get; set; }
        public virtual DbSet<ServiceCatagoriesList> ServiceCatagoriesList { get; set; }
        public virtual DbSet<ServiceCategories> ServiceCategories { get; set; }
        public virtual DbSet<ServiceList> ServiceList { get; set; }
        public virtual DbSet<ServiceProvidersAudit> ServiceProvidersAudit { get; set; }
        public virtual DbSet<ServiceSubCatagories> ServiceSubCatagories { get; set; }
        public virtual DbSet<ServiceSubCategoriesList> ServiceSubCategoriesList { get; set; }
        public virtual DbSet<Serviceprovider> Serviceprovider { get; set; }
        public virtual DbSet<ServiceproviderTenantMapping> ServiceproviderTenantMapping { get; set; }
        public virtual DbSet<Serviceprovideraddress> Serviceprovideraddress { get; set; }
        public virtual DbSet<Serviceprovidercategory> Serviceprovidercategory { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Suburbs> Suburbs { get; set; }
        public virtual DbSet<SuburbsList> SuburbsList { get; set; }
        public virtual DbSet<Tenant> Tenant { get; set; }
        public virtual DbSet<Token> Token { get; set; }
        public virtual DbSet<UserClient> UserClient { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Ussdtest> Ussdtest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=gcapp-mysql.mysql.database.azure.com;port=3306;user=gcsysops@gcapp-mysql;password=9zgGEQs7b&Gm;database=halo;treattinyasboolean=true", x => x.ServerVersion("5.7.27-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.HasIndex(e => e.CountryId)
                    .HasName("FK_Address_Country_CountryId");

                entity.HasIndex(e => e.ServiceProviderId)
                    .HasName("FK_Address_ServiceProvider_ServiceProviderId");

                entity.HasIndex(e => e.StateProvinceId)
                    .HasName("FK_Address_StateProvince_StateProvinceId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Address1)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address3)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address4)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CityId).HasColumnType("int(11)");

                entity.Property(e => e.CountryId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOnUtc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceProviderId).HasColumnType("int(11)");

                entity.Property(e => e.StateProvinceId).HasColumnType("int(11)");

                entity.Property(e => e.Suburb)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SuburbId).HasColumnType("int(11)");

                entity.Property(e => e.ZipPostalCode)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Address_Country_CountryId");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_Address_ServiceProvider_ServiceProviderId");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StateProvinceId)
                    .HasConstraintName("FK_Address_StateProvince_StateProvinceId");
            });

            modelBuilder.Entity<Apilogger>(entity =>
            {
                entity.HasKey(e => e.LoggerId)
                    .HasName("PRIMARY");

                entity.ToTable("apilogger");

                entity.Property(e => e.LoggerId)
                    .HasColumnName("LoggerID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Apikey)
                    .HasColumnName("APIKey")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContentType)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Host)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsHttps)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LoggerApi)
                    .HasColumnName("LoggerAPI")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Method)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Path)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Protocol)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.QueryString)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RemoteIpAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Scheme)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Applicationdistributions>(entity =>
            {
                entity.HasKey(e => e.DistroId)
                    .HasName("PRIMARY");

                entity.ToTable("applicationdistributions");

                entity.Property(e => e.DistroId)
                    .HasColumnName("DistroID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DistroJson)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistroNamespace)
                    .HasColumnType("varchar(63)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DistroTitle)
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ArcherDeliveryReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("archer_delivery_report");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnName("delivery_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeliveryId)
                    .HasColumnName("delivery_id")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Json)
                    .HasColumnName("json")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageId)
                    .IsRequired()
                    .HasColumnName("message_id")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Msisdn)
                    .HasColumnName("msisdn")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SentDate)
                    .HasColumnName("sent_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusCode)
                    .HasColumnName("status_code")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ArchiveHaloclientmembers>(entity =>
            {
                entity.HasKey(e => e.HaloClientMemberId)
                    .HasName("PRIMARY");

                entity.ToTable("archive_haloclientmembers");

                entity.Property(e => e.HaloClientMemberId)
                    .HasColumnName("HaloClientMemberID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ArchiveHaloinappregistration>(entity =>
            {
                entity.HasKey(e => e.IdarchiveHaloinappregistration)
                    .HasName("PRIMARY");

                entity.ToTable("archive_haloinappregistration");

                entity.Property(e => e.IdarchiveHaloinappregistration)
                    .HasColumnName("idarchive_haloinappregistration")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MemberId)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ArchiveHalomemberprograms>(entity =>
            {
                entity.HasKey(e => e.ArchiveId)
                    .HasName("PRIMARY");

                entity.ToTable("archive_halomemberprograms");

                entity.Property(e => e.ArchiveId)
                    .HasColumnName("archive_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberProgramId)
                    .HasColumnName("HaloMemberProgramID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloProgramId)
                    .HasColumnName("HaloProgramID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ArchiveHalomembers>(entity =>
            {
                entity.HasKey(e => e.ArchiveId)
                    .HasName("PRIMARY");

                entity.ToTable("archive_halomembers");

                entity.Property(e => e.ArchiveId)
                    .HasColumnName("archive_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("varchar(512)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberActivateDate)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberActive)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberAllergies)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberBloodDonorNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberBloodType)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberBusinessName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberDataKey)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberDateOfBirth)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberEmailAddress)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberEmergencyContactName1)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberEmergencyContactName2)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberEmergencyContactNumber1)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberEmergencyContactNumber2)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberFullName)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberGender)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberHash)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberHomeAddress)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberHomeLatitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberHomeLongitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberHomePhoneNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberIdnumber)
                    .HasColumnName("HaloMemberIDNumber")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberIdtype)
                    .HasColumnName("HaloMemberIDType")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberImage)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberIsHashed)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberLanguage)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberLoadDate)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberMedicalAidName)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberMedicalAidNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberMedicalAidScheme)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberModifiedDate)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberName)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberOccupation)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberOtp)
                    .HasColumnName("HaloMemberOTP")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberPassword)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberSurname)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberToken)
                    .HasColumnType("varchar(500)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberVat)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberWelcomeEmailSent)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberWorkAddress)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberWorkPhoneNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ArchiveHalophonenumbers>(entity =>
            {
                entity.HasKey(e => e.ArchiveId)
                    .HasName("PRIMARY");

                entity.ToTable("archive_halophonenumbers");

                entity.Property(e => e.ArchiveId)
                    .HasColumnName("archive_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberPhoneNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberPhoneNumberId)
                    .HasColumnName("HaloMemberPhoneNumberID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ArchiveHalovehiclelicences>(entity =>
            {
                entity.HasKey(e => e.ArchiveId)
                    .HasName("PRIMARY");

                entity.ToTable("archive_halovehiclelicences");

                entity.Property(e => e.ArchiveId)
                    .HasColumnName("archive_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ControlNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.DateDeleted)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.EngineNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloVehicleLicenceId)
                    .HasColumnName("HaloVehicleLicenceID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LicenceNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RegisterNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SeriesName)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.VehicleColour)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.VehicleDescription)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.VehicleMake)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.VehicleYear)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.VinNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Authtokens>(entity =>
            {
                entity.HasKey(e => e.AtId)
                    .HasName("PRIMARY");

                entity.ToTable("authtokens");

                entity.Property(e => e.AtId)
                    .HasColumnName("at_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtClientId)
                    .HasColumnName("at_client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AtJwt)
                    .HasColumnName("at_jwt")
                    .HasColumnType("varchar(1023)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AtPassword)
                    .HasColumnName("at_password")
                    .HasColumnType("varchar(1023)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AtUserName)
                    .HasColumnName("at_user_name")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<BrokerUser>(entity =>
            {
                entity.ToTable("broker_user");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClientId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(1023)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MobileNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ModifiedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Secret)
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TenantId)
                    .IsRequired()
                    .HasColumnType("varchar(60)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Username)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Callcentreaudittrail>(entity =>
            {
                entity.ToTable("callcentreaudittrail");

                entity.Property(e => e.CallCentreAuditTrailId)
                    .HasColumnName("CallCentreAuditTrailID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreAuditTrailDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CallCentreAuditTrailTransaction)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreAuditTrailUserId)
                    .HasColumnName("CallCentreAuditTrailUserID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Callcentrechatmessages>(entity =>
            {
                entity.HasKey(e => e.CallCentreChatMessageId)
                    .HasName("PRIMARY");

                entity.ToTable("callcentrechatmessages");

                entity.Property(e => e.CallCentreChatMessageId)
                    .HasColumnName("CallCentreChatMessageID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreChatMessage)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreChatMessageRead).HasDefaultValueSql("'0'");

                entity.Property(e => e.CallCentreChatMessageSentAt)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.CallCentreChatMessageSentFrom).HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreChatMessageSentTo).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Callcentrefaqs>(entity =>
            {
                entity.HasKey(e => e.CallCentreFaqid)
                    .HasName("PRIMARY");

                entity.ToTable("callcentrefaqs");

                entity.Property(e => e.CallCentreFaqid)
                    .HasColumnName("CallCentreFAQID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreFaqanswer)
                    .HasColumnName("CallCentreFAQAnswer")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreFaqquestion)
                    .HasColumnName("CallCentreFAQQuestion")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Callcentrefirestations>(entity =>
            {
                entity.HasKey(e => e.CallCentreFireStationId)
                    .HasName("PRIMARY");

                entity.ToTable("callcentrefirestations");

                entity.Property(e => e.CallCentreFireStationId)
                    .HasColumnName("CallCentreFireStationID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreFireStationAddress)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreFireStationLat)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreFireStationLng)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreFireStationName)
                    .HasColumnType("varchar(55)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreFireStationPhoneNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Callcentremodules>(entity =>
            {
                entity.HasKey(e => e.CallCentreModuleId)
                    .HasName("PRIMARY");

                entity.ToTable("callcentremodules");

                entity.Property(e => e.CallCentreModuleId)
                    .HasColumnName("CallCentreModuleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CallCentreModuleHtml)
                    .HasColumnName("CallCentreModuleHTML")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreModuleName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreModuleOrder).HasColumnType("int(11)");

                entity.Property(e => e.CallCentreModuleScript)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreModuleSubNames)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Callcentrerolemodules>(entity =>
            {
                entity.HasKey(e => e.CallCentreRoleModuleId)
                    .HasName("PRIMARY");

                entity.ToTable("callcentrerolemodules");

                entity.Property(e => e.CallCentreRoleModuleId)
                    .HasColumnName("CallCentreRoleModuleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CallCentreModuleId)
                    .HasColumnName("CallCentreModuleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CallCentreRoleId)
                    .HasColumnName("CallCentreRoleID")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Callcentreuserroles>(entity =>
            {
                entity.HasKey(e => e.CallCentreUserRoleId)
                    .HasName("PRIMARY");

                entity.ToTable("callcentreuserroles");

                entity.HasComment("utf8_general_ci");

                entity.Property(e => e.CallCentreUserRoleId)
                    .HasColumnName("CallCentreUserRoleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CallCentreUserRoleName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Callcentreusers>(entity =>
            {
                entity.HasKey(e => e.CallCentreUserId)
                    .HasName("PRIMARY");

                entity.ToTable("callcentreusers");

                entity.HasComment("utf8_general_ci");

                entity.HasIndex(e => e.CallCentreUserName)
                    .HasName("CallCentreUserName_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CallCentreUserId)
                    .HasColumnName("CallCentreUserID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CallCentreUserFirstName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreUserHash)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreUserIsHashed)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CallCentreUserName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CallCentreUserPassword)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.CallCentreUserRole).HasColumnType("smallint(6)");

                entity.Property(e => e.CallCentreUserStatus)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CallCentreUserSurname)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Cartrack>(entity =>
            {
                entity.ToTable("cartrack");

                entity.HasComment("		");

                entity.Property(e => e.CarTrackId)
                    .HasColumnName("CarTrackID")
                    .HasColumnType("bigint(10)");

                entity.Property(e => e.CarTrackCellphoneNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackClientName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackClientNo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackEmail)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackEngineNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackHaloMemberId).HasColumnType("bigint(10)");

                entity.Property(e => e.CarTrackIdNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackModel)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackPolicyNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackRegistrationNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackVehicleMake)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CarTrackVinNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Alias)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BottomDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryTemplateId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOnUtc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Deleted).HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.FullName)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Icon)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaKeywords)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MetaTitle)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentCategoryId).HasColumnType("int(11)");

                entity.Property(e => e.Published).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedOnUtc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PRIMARY");

                entity.ToTable("cities");

                entity.HasIndex(e => e.CityId)
                    .HasName("city_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CityDescription)
                    .HasColumnName("city_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegionId)
                    .HasColumnName("region_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CitiesList>(entity =>
            {
                entity.ToTable("cities_list");

                entity.HasIndex(e => e.CitiesListId)
                    .HasName("cities_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CitiesListId)
                    .HasColumnName("cities_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CitiesListDescription)
                    .HasColumnName("cities_list_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CitiesListName)
                    .HasColumnName("cities_list_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ClientTokens>(entity =>
            {
                entity.ToTable("client_tokens");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("client_id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.TokensAvailable)
                    .HasColumnName("tokens_available")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TokensBrought)
                    .HasColumnName("tokens_brought")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasDefaultValueSql("'00000000000'");

                entity.Property(e => e.TokensUsed)
                    .HasColumnName("tokens_used")
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasDefaultValueSql("'00000000000'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Cmsmodules>(entity =>
            {
                entity.HasKey(e => e.CmsmoduleId)
                    .HasName("PRIMARY");

                entity.ToTable("cmsmodules");

                entity.Property(e => e.CmsmoduleId)
                    .HasColumnName("CMSModuleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CmsmoduleHtml)
                    .HasColumnName("CMSModuleHTML")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CmsmoduleName)
                    .HasColumnName("CMSModuleName")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CmsmoduleOrder)
                    .HasColumnName("CMSModuleOrder")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CmsmoduleScript)
                    .HasColumnName("CMSModuleScript")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CmsmoduleSubNames)
                    .HasColumnName("CMSModuleSubNames")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Cmsrolemodules>(entity =>
            {
                entity.HasKey(e => e.CmsroleModuleId)
                    .HasName("PRIMARY");

                entity.ToTable("cmsrolemodules");

                entity.Property(e => e.CmsroleModuleId)
                    .HasColumnName("CMSRoleModuleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CmsmoduleId)
                    .HasColumnName("CMSModuleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CmsroleId)
                    .HasColumnName("CMSRoleID")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<Cmsuserroles>(entity =>
            {
                entity.HasKey(e => e.CmsuserRoleId)
                    .HasName("PRIMARY");

                entity.ToTable("cmsuserroles");

                entity.Property(e => e.CmsuserRoleId)
                    .HasColumnName("CMSUserRoleID")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CmsuserRoleName)
                    .HasColumnName("CMSUserRoleName")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Cmsusers>(entity =>
            {
                entity.HasKey(e => e.CmsuserId)
                    .HasName("PRIMARY");

                entity.ToTable("cmsusers");

                entity.HasIndex(e => e.CmsuserName)
                    .HasName("CMSUserName_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.CmsuserRole)
                    .HasName("fk_CMSUsers_1_idx");

                entity.Property(e => e.CmsuserId)
                    .HasColumnName("CMSUserID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CmsuserName)
                    .HasColumnName("CMSUserName")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CmsuserPassword)
                    .HasColumnName("CMSUserPassword")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.CmsuserRole)
                    .HasColumnName("CMSUserRole")
                    .HasColumnType("smallint(6)");

                entity.Property(e => e.CmsuserStatus)
                    .HasColumnName("CMSUserStatus")
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CmsuserSurname)
                    .HasColumnName("CMSUserSurname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Communicationlog>(entity =>
            {
                entity.ToTable("communicationlog");

                entity.HasIndex(e => e.Id)
                    .HasName("CommunicationLog_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Body)
                    .HasColumnName("body")
                    .HasColumnType("varchar(8192)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SentAt)
                    .HasColumnName("sent_at")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PRIMARY");

                entity.ToTable("contacts");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ContactLastName)
                    .HasColumnType("varchar(1023)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactName)
                    .HasColumnType("varchar(1023)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactNumber)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactStatus).HasColumnType("int(2)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.HasIndex(e => e.CountryId)
                    .HasName("country_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryDescription)
                    .HasColumnName("country_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceSubCatagorieId)
                    .HasColumnName("service_sub_catagorie_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<CountryList>(entity =>
            {
                entity.ToTable("country_list");

                entity.HasIndex(e => e.CountryListId)
                    .HasName("country_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CountryListId)
                    .HasColumnName("country_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryListDescription)
                    .HasColumnName("country_list_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryListName)
                    .HasColumnName("country_list_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<EdmundsTest>(entity =>
            {
                entity.ToTable("edmunds_test");

                entity.HasComment("Edmunds Disruptifi Test Database");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EdmundsAddress1)
                    .HasColumnName("edmunds_address1")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EdmundsAddress2)
                    .HasColumnName("edmunds_address2")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EdmundsCity)
                    .HasColumnName("edmunds_city")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EdmundsName)
                    .HasColumnName("edmunds_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EdmundsPayDate)
                    .HasColumnName("edmunds_pay_date")
                    .HasColumnType("timestamp");

                entity.Property(e => e.EdmundsProvince)
                    .HasColumnName("edmunds_province")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EdmundsSalary)
                    .HasColumnName("edmunds_salary")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EdmundsSurname)
                    .HasColumnName("edmunds_surname")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EdmundsYearsWorked)
                    .HasColumnName("edmunds_years_worked")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<FnolCity>(entity =>
            {
                entity.ToTable("fnol_city");

                entity.HasIndex(e => e.CountryId)
                    .HasName("FK_City_Country_CountryId");

                entity.HasIndex(e => e.StateProvinceId)
                    .HasName("FK_City_StateProvince_StateProvinceId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Abbreviation)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryId).HasColumnType("int(11)");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published).HasColumnType("int(11)");

                entity.Property(e => e.StateProvinceId).HasColumnType("int(11)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.FnolCity)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_City_Country_CountryId");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.FnolCity)
                    .HasForeignKey(d => d.StateProvinceId)
                    .HasConstraintName("FK_City_StateProvince_StateProvinceId");
            });

            modelBuilder.Entity<FnolClaim>(entity =>
            {
                entity.ToTable("fnol_claim");

                entity.HasIndex(e => e.ReferenceNumber)
                    .HasName("ReferenceNumber_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UniqueId)
                    .HasName("UniqueId_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClientId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EntityId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.JsonContent)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReferenceNumber)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubmittedByEntityType)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubmittedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.TenantId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<FnolCountry>(entity =>
            {
                entity.ToTable("fnol_country");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NumericIsoCode).HasColumnType("int(11)");

                entity.Property(e => e.Published).HasColumnType("int(11)");

                entity.Property(e => e.ThreeLetterIsoCode)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TwoLetterIsoCode)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<FnolDocument>(entity =>
            {
                entity.ToTable("fnol_document");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.MimeType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PolicyNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Size).HasColumnType("int(11)");

                entity.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<FnolStateprovince>(entity =>
            {
                entity.ToTable("fnol_stateprovince");

                entity.HasIndex(e => e.CountryId)
                    .HasName("FK_StateProvince_Country_CountryId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Abbreviation)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published).HasColumnType("int(11)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.FnolStateprovince)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_StateProvince_Country_CountryId");
            });

            modelBuilder.Entity<FnolSuburb>(entity =>
            {
                entity.ToTable("fnol_suburb");

                entity.HasIndex(e => e.CountryId)
                    .HasName("FK_Suburb_Country_CountryId");

                entity.HasIndex(e => e.StateProvinceId)
                    .HasName("FK_Suburb_StateProvince_StateProvinceId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Abbreviation)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CityId).HasColumnType("int(11)");

                entity.Property(e => e.CountryId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published).HasColumnType("int(11)");

                entity.Property(e => e.StateProvinceId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.FnolSuburb)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Suburb_Country_CountryId");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.FnolSuburb)
                    .HasForeignKey(d => d.StateProvinceId)
                    .HasConstraintName("FK_Suburb_StateProvince_StateProvinceId");
            });

            modelBuilder.Entity<HaloMobileContentClients>(entity =>
            {
                entity.ToTable("halo_mobile_content_clients");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloMobileClientId)
                    .HasColumnName("halo_mobile_client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloMobileContentId)
                    .HasColumnName("halo_mobile_content_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Haloaudittrail>(entity =>
            {
                entity.ToTable("haloaudittrail");

                entity.Property(e => e.HaloAuditTrailId)
                    .HasColumnName("HaloAuditTrailID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloAuditDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloAuditTrailStatus)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloAuditTrailTransaction)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloAuditTrailUserId)
                    .HasColumnName("HaloAuditTrailUserID")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halobatchimported>(entity =>
            {
                entity.ToTable("halobatchimported");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Amount)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Date)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Failed)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halobranches>(entity =>
            {
                entity.HasKey(e => e.HaloBranchId)
                    .HasName("PRIMARY");

                entity.ToTable("halobranches");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloBranches_1_idx");

                entity.Property(e => e.HaloBranchId)
                    .HasColumnName("HaloBranchID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloBranchEmailAddress)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloBranchName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloBranchPhoneNumbers)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloBranchPhysicalAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloBranchPostalAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloClient)
                    .WithMany(p => p.Halobranches)
                    .HasForeignKey(d => d.HaloClientId)
                    .HasConstraintName("fk_HaloBranches_1");
            });

            modelBuilder.Entity<Halochatmessages>(entity =>
            {
                entity.HasKey(e => e.HaloChatMessageId)
                    .HasName("PRIMARY");

                entity.ToTable("halochatmessages");

                entity.HasIndex(e => e.HaloChatRequestId)
                    .HasName("fk_HaloChatMessages_1_idx");

                entity.Property(e => e.HaloChatMessageId)
                    .HasColumnName("HaloChatMessageID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatMessage)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloChatMessageSentAt)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloChatMessageSentFrom).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatMessageSentTo).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatMessageType)
                    .HasColumnType("varchar(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloChatRequestId)
                    .HasColumnName("HaloChatRequestID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halochatrequests>(entity =>
            {
                entity.HasKey(e => e.HaloChatRequestId)
                    .HasName("PRIMARY");

                entity.ToTable("halochatrequests");

                entity.Property(e => e.HaloChatRequestId)
                    .HasColumnName("HaloChatRequestID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatRequestActive).HasDefaultValueSql("'1'");

                entity.Property(e => e.HaloChatRequestHandledAt)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloChatRequestHandledBy).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatRequestHasUnread).HasDefaultValueSql("'0'");

                entity.Property(e => e.HaloChatRequestLastTransaction)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloChatRequestLatitude)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloChatRequestLongitude)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloChatRequestMemberId)
                    .HasColumnName("HaloChatRequestMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloChatRequestMemberPhoneNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloChatRequestTimeStamp)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Haloclaims>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PRIMARY");

                entity.ToTable("haloclaims");

                entity.Property(e => e.ClaimId)
                    .HasColumnName("ClaimID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClaimClientId)
                    .HasColumnName("ClaimClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ClaimCreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ClaimJson)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClaimModifiedAt).HasColumnType("datetime");

                entity.Property(e => e.ClaimReference)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClaimStatus).HasColumnType("int(11)");

                entity.Property(e => e.ClaimSubmittedAt).HasColumnType("datetime");

                entity.Property(e => e.ClaimType).HasColumnType("int(11)");

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Haloclaimtypes>(entity =>
            {
                entity.ToTable("haloclaimtypes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CimsType)
                    .HasColumnName("cimsType")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasColumnName("claimType")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("groupName")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Haloclientapiregister>(entity =>
            {
                entity.HasKey(e => e.Apiclientid)
                    .HasName("PRIMARY");

                entity.ToTable("haloclientapiregister");

                entity.Property(e => e.Apiclientid)
                    .HasColumnName("apiclientid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Clientemail)
                    .IsRequired()
                    .HasColumnName("clientemail")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Clientname)
                    .IsRequired()
                    .HasColumnName("clientname")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Createdat)
                    .HasColumnName("createdat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Passwordhash)
                    .IsRequired()
                    .HasColumnName("passwordhash")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Haloclientbanners>(entity =>
            {
                entity.HasKey(e => e.HaloClientBannerId)
                    .HasName("PRIMARY");

                entity.ToTable("haloclientbanners");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloClientBanners_1_idx");

                entity.Property(e => e.HaloClientBannerId)
                    .HasColumnName("HaloClientBannerID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientBannerPath)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloClient)
                    .WithMany(p => p.Haloclientbanners)
                    .HasForeignKey(d => d.HaloClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloClientBanners_1");
            });

            modelBuilder.Entity<Haloclientmembers>(entity =>
            {
                entity.HasKey(e => e.HaloClientMemberId)
                    .HasName("PRIMARY");

                entity.ToTable("haloclientmembers");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloClientMembers_1_idx");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloClientMembers_2_idx");

                entity.Property(e => e.HaloClientMemberId)
                    .HasColumnName("HaloClientMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Haloclientpartners>(entity =>
            {
                entity.HasKey(e => e.HaloClientPartnerId)
                    .HasName("PRIMARY");

                entity.ToTable("haloclientpartners");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloClientPartners_1_idx");

                entity.Property(e => e.HaloClientPartnerId)
                    .HasColumnName("HaloClientPartnerID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloPartnerId)
                    .HasColumnName("HaloPartnerID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloClient)
                    .WithMany(p => p.Haloclientpartners)
                    .HasForeignKey(d => d.HaloClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloClientPartners_1");
            });

            modelBuilder.Entity<Haloclientprogramproducts>(entity =>
            {
                entity.HasKey(e => e.HaloClientProgramProductId)
                    .HasName("PRIMARY");

                entity.ToTable("haloclientprogramproducts");

                entity.HasIndex(e => e.HaloClientProgramId)
                    .HasName("fk_HaloClientProgramProducts_1_idx");

                entity.Property(e => e.HaloClientProgramProductId)
                    .HasColumnName("HaloClientProgramProductID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramId)
                    .HasColumnName("HaloClientProgramID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramProductDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientProgramProductIcon)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientProgramProductIndex).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramProductName)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientProgramProductOrder).HasColumnType("int(11)");

                entity.Property(e => e.HaloClientProgramProductPhone)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientProgramProductPrice).HasColumnType("decimal(8,2)");

                entity.Property(e => e.HaloClientProgramProductTerms)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Haloclientprograms>(entity =>
            {
                entity.HasKey(e => e.HaloClientProgramId)
                    .HasName("PRIMARY");

                entity.ToTable("haloclientprograms");

                entity.HasIndex(e => e.HaloClientProgramClientId)
                    .HasName("fk_HaloClientPrograms_1_idx");

                entity.Property(e => e.HaloClientProgramId)
                    .HasColumnName("HaloClientProgramID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramClientId)
                    .HasColumnName("HaloClientProgramClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientProgramCode)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.HaloClientProgramClient)
                    .WithMany(p => p.Haloclientprograms)
                    .HasForeignKey(d => d.HaloClientProgramClientId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloClientPrograms_1");
            });

            modelBuilder.Entity<Haloclients>(entity =>
            {
                entity.HasKey(e => e.HaloClientId)
                    .HasName("PRIMARY");

                entity.ToTable("haloclients");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientAbout)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientClaimEmailAddress)
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientCode)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientContactDetailsInfo)
                    .HasColumnType("varchar(512)")
                    .HasDefaultValueSql("'This innovative app service is provided by Global Choices as a result of your insurance policy with ?CLIENTNAME?.'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientEmailAddress)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientEmergencyPhoneNumber)
                    .HasColumnType("varchar(16)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientFspnumber)
                    .HasColumnName("HaloClientFSPNumber")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientLogoPath)
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("'/images/clients/default/logo.png'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientPdflogoPath)
                    .HasColumnName("HaloClientPDFLogoPath")
                    .HasColumnType("varchar(80)")
                    .HasDefaultValueSql("'/images/clients/default/logo.png'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientPhoneNumbers)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientPhysicalAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientPostalAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientRegistrationDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloClientResetMessage)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientServices)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientSmscredits)
                    .HasColumnName("HaloClientSMSCredits")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HaloClientWebsite)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientWelcomeMessage)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Haloclientslogin>(entity =>
            {
                entity.HasKey(e => e.HaloClientLoginId)
                    .HasName("PRIMARY");

                entity.ToTable("haloclientslogin");

                entity.Property(e => e.HaloClientLoginId)
                    .HasColumnName("HaloClientLoginID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientPassword)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.HaloClientStatus).HasColumnType("smallint(1)");

                entity.Property(e => e.HaloClientUserName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloClientUserSurname)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<HalodictionaryEnZa>(entity =>
            {
                entity.ToTable("halodictionary_en_za");

                entity.HasComment("This table should not ever be editted, only appended");

                entity.HasIndex(e => e.Key)
                    .HasName("key_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Halodriverslicences>(entity =>
            {
                entity.HasKey(e => e.HaloDriversLicenceId)
                    .HasName("PRIMARY");

                entity.ToTable("halodriverslicences");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloDriversLicences_1_idx");

                entity.Property(e => e.HaloDriversLicenceId)
                    .HasColumnName("HaloDriversLicenceID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CertificateNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Class1FirstIssueDate)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Class1VehicleCode)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Class1VehicleRestrictions)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Class2FirstIssueDate)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Class2VehicleCode)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Class2VehicleRestrictions)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Class3FirstIssueDate)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Class3VehicleCode)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Class3VehicleRestrictions)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryOfIssue)
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DriverRestrictions1)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DriverRestrictions2)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gender)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Idnumber)
                    .HasColumnName("IDNumber")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Initials)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IssueNumber)
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LicencePhoto)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pdpcategory)
                    .HasColumnName("PDPCategory")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PdpvalidTo)
                    .HasColumnName("PDPValidTo")
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Surname)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidFrom)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValidTo)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halofasttrackclaims>(entity =>
            {
                entity.HasKey(e => e.IdhaloFastTrackClaim)
                    .HasName("PRIMARY");

                entity.ToTable("halofasttrackclaims");

                entity.Property(e => e.IdhaloFastTrackClaim)
                    .HasColumnName("idhaloFastTrackClaim")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloFastTrackClaimDateTime)
                    .HasColumnName("haloFastTrackClaimDateTime")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloFastTrackClaimType)
                    .HasColumnName("haloFastTrackClaimType")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberIdnumber)
                    .HasColumnName("haloMemberIDNumber")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberPolicyNumber)
                    .HasColumnName("haloMemberPolicyNumber")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Halofrontlinephone>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("halofrontlinephone");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloMemberPhoneNumber)
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloMemberPhoneNumberId)
                    .HasColumnName("HaloMemberPhoneNumberID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Haloftpaudittrail>(entity =>
            {
                entity.ToTable("haloftpaudittrail");

                entity.Property(e => e.HaloFtpauditTrailId)
                    .HasColumnName("HaloFTPAuditTrailID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloFtpauditTrailClientId)
                    .HasColumnName("HaloFTPAuditTrailClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloFtpauditTrailFileDateTime)
                    .HasColumnName("HaloFTPAuditTrailFileDateTime")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloFtpauditTrailFileFrom)
                    .HasColumnName("HaloFTPAuditTrailFileFrom")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloFtpauditTrailFileName)
                    .HasColumnName("HaloFTPAuditTrailFileName")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloFtpauditTrailProcDateTime)
                    .HasColumnName("HaloFTPAuditTrailProcDateTime")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloFtpauditTrailStatus)
                    .HasColumnName("HaloFTPAuditTrailStatus")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Haloinappapplications>(entity =>
            {
                entity.ToTable("haloinappapplications");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("ProjectID")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RestApiKey)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Haloinappmessages>(entity =>
            {
                entity.ToTable("haloinappmessages");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_At")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Read)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReadAt)
                    .HasColumnName("Read_At")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Sent)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SentAt)
                    .HasColumnName("Sent_At")
                    .HasColumnType("timestamp");

                entity.Property(e => e.Subject)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Haloinappregistration>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PRIMARY");

                entity.ToTable("haloinappregistration");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<HalomemberAdditionalClientData>(entity =>
            {
                entity.ToTable("halomember_additional_client_data");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClientId).HasColumnType("int(11)");

                entity.Property(e => e.ClientIdentifier)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.MemberId).HasColumnType("int(11)");

                entity.Property(e => e.Programme)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PropCount).HasColumnType("int(11)");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.VehicleCount).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Halomemberclaims>(entity =>
            {
                entity.HasKey(e => e.HaloMemberClaimId)
                    .HasName("PRIMARY");

                entity.ToTable("halomemberclaims");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloMemberClaims_1_idx");

                entity.Property(e => e.HaloMemberClaimId)
                    .HasColumnName("HaloMemberClaimID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberClaimIncidentAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimIncidentContactNumber)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimIncidentDate)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimIncidentDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimIncidentIdnumber)
                    .HasColumnName("HaloMemberClaimIncidentIDNumber")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimIncidentName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimIncidentSurname)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimIncidentTime)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimPicBack)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimPicFront)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimPicLabel)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimPicLeft)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimPicLicence)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimPicOdo)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimPicRight)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimPicWindscreen)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimSubmitted)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloMemberClaimTowingCompanyContact)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimTowingCompanyDriver)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimTowingCompanyName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleColour)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleControlNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleDescription)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleEngineNumber)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleExpiryDate)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleLicenceNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleMake)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleRegisterNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleSeriesName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimVehicleVinNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloMember)
                    .WithMany(p => p.Halomemberclaims)
                    .HasForeignKey(d => d.HaloMemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloMemberClaims_1");
            });

            modelBuilder.Entity<Halomemberclaimseyewitness>(entity =>
            {
                entity.ToTable("halomemberclaimseyewitness");

                entity.HasIndex(e => e.HaloMemberClaimsId)
                    .HasName("fk_HaloMemberClaimsEyewitness_1_idx");

                entity.Property(e => e.HaloMemberClaimsEyewitnessId)
                    .HasColumnName("HaloMemberClaimsEyewitnessID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberClaimsEyewitnessAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsEyewitnessContact)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsEyewitnessName)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsId)
                    .HasColumnName("HaloMemberClaimsID")
                    .HasColumnType("bigint(20)");

                entity.HasOne(d => d.HaloMemberClaims)
                    .WithMany(p => p.Halomemberclaimseyewitness)
                    .HasForeignKey(d => d.HaloMemberClaimsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloMemberClaimsEyewitness_1");
            });

            modelBuilder.Entity<Halomemberclaimsthirdparty>(entity =>
            {
                entity.ToTable("halomemberclaimsthirdparty");

                entity.HasIndex(e => e.HaloMemberClaimId)
                    .HasName("fk_HaloMemberClaimsThirdParty_1_idx");

                entity.Property(e => e.HaloMemberClaimsThirdPartyId)
                    .HasColumnName("HaloMemberClaimsThirdPartyID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberClaimId)
                    .HasColumnName("HaloMemberClaimID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberClaimsThirdPartyAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyColour)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyContact)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyControlNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyDescription)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyEngineNumber)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyExpiryDate)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyLicenceNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyMake)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicBack)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicFront)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicLabel)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicLeft)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicLicence)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicOdo)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicRight)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyPicWindscreen)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyRegisterNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartySeriesName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberClaimsThirdPartyVinNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.HaloMemberClaim)
                    .WithMany(p => p.Halomemberclaimsthirdparty)
                    .HasForeignKey(d => d.HaloMemberClaimId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_HaloMemberClaimsThirdParty_1");
            });

            modelBuilder.Entity<Halomemberdependants>(entity =>
            {
                entity.HasKey(e => e.HaloDependantId)
                    .HasName("PRIMARY");

                entity.ToTable("halomemberdependants");

                entity.HasIndex(e => e.HaloDependantCellPhoneNumber)
                    .HasName("HaloDependantCellPhoneNumber_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloMemberDependants_1_idx");

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloDependantActive)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.HaloDependantAllergies)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantBloodDonorNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantBloodType)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantBusinessName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantCellPhoneNumber)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantDateAdded)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloDependantDateOfBirth)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantEmailAddress)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantEmergencyContactName1)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantEmergencyContactName2)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantEmergencyContactNumber1)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantEmergencyContactNumber2)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantFullName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantGender)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantHash)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantHomeAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantHomeLatitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantHomeLongitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantHomePhoneNumber)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantIdnumber)
                    .HasColumnName("HaloDependantIDNumber")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantIdtype)
                    .HasColumnName("HaloDependantIDType")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantImage)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantIsHashed)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.HaloDependantLanguage)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantMedicalAidName)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantMedicalAidNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantMedicalAidScheme)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantOccupation)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantRelationship)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantSurname)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantTmpIndex)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantWorkAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantWorkPhoneNumber)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberDependantOtp)
                    .HasColumnName("HaloMemberDependantOTP")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberDependantPassword)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberDependantToken)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halomemberftpfiles>(entity =>
            {
                entity.ToTable("halomemberftpfiles");

                entity.HasIndex(e => e.HaloMemberFtpFilesId)
                    .HasName("HaloMemberFtpFilesID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.HaloMemberFtpFilesId)
                    .HasColumnName("HaloMemberFtpFilesID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberFtpFileProcessed)
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'\"No\"'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberFtpFilesEmailSent)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberFtpFilesFileName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberFtpFilesTimeStamp)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberFtpFolderName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halomemberidtialpolicyinfo>(entity =>
            {
                entity.HasKey(e => e.Idhalomembertialpolicynumber)
                    .HasName("PRIMARY");

                entity.ToTable("halomemberidtialpolicyinfo");

                entity.Property(e => e.Idhalomembertialpolicynumber)
                    .HasColumnName("idhalomembertialpolicynumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Halomemberidnumber)
                    .HasColumnName("halomemberidnumber")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Halomemberidtialpolicyjson)
                    .HasColumnName("halomemberidtialpolicyjson")
                    .HasColumnType("longtext")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Halomemberpolicynumbercol)
                    .HasColumnName("halomemberpolicynumbercol")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Policyjsonentryepochtime)
                    .HasColumnName("policyjsonentryepochtime")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Halomemberloaderror>(entity =>
            {
                entity.ToTable("halomemberloaderror");

                entity.Property(e => e.HaloMemberLoadErrorId)
                    .HasColumnName("HaloMemberLoadErrorID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloMemberLoadErrorDateSent)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorDescription)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorEmail)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorEmailSent)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorFtpFileName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorIdNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorIdType)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorMobileNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorPolicyNumber)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorSurname)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadErrorTimeStamp)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halomembermessages>(entity =>
            {
                entity.HasKey(e => e.HaloMemberMessageId)
                    .HasName("PRIMARY");

                entity.ToTable("halomembermessages");

                entity.Property(e => e.HaloMemberMessageId)
                    .HasColumnName("HaloMemberMessageID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberMessage)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberMessageDeleted).HasDefaultValueSql("'0'");

                entity.Property(e => e.HaloMemberMessageRead).HasDefaultValueSql("'0'");

                entity.Property(e => e.HaloMemberMessageSentAt)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloMemberMessageSentFromId)
                    .HasColumnName("HaloMemberMessageSentFromID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberMessageSentFromName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberMessageSentTo).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halomemberphonenumbers>(entity =>
            {
                entity.HasKey(e => e.HaloMemberPhoneNumberId)
                    .HasName("PRIMARY");

                entity.ToTable("halomemberphonenumbers");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloMemberPhoneNumbers_1_idx");

                entity.Property(e => e.HaloMemberPhoneNumberId)
                    .HasColumnName("HaloMemberPhoneNumberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberPhoneNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halomemberprograms>(entity =>
            {
                entity.HasKey(e => e.HaloMemberProgramId)
                    .HasName("PRIMARY");

                entity.ToTable("halomemberprograms");

                entity.HasIndex(e => e.HaloClientId)
                    .HasName("fk_HaloMemberPrograms_1_idx");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloMemberPrograms_2_idx");

                entity.HasIndex(e => e.HaloProgramId)
                    .HasName("fk_HaloMemberPrograms_3_idx");

                entity.Property(e => e.HaloMemberProgramId)
                    .HasColumnName("HaloMemberProgramID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("HaloClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloProgramId)
                    .HasColumnName("HaloProgramID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halomembers>(entity =>
            {
                entity.HasKey(e => e.HaloMemberId)
                    .HasName("PRIMARY");

                entity.ToTable("halomembers");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberActivateDate).HasColumnType("timestamp");

                entity.Property(e => e.HaloMemberActive)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.HaloMemberAllergies)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberBloodDonorNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberBloodType)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberBranch)
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberBusinessName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberDataKey)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberDateOfBirth)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmailAddress)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmergencyContactName1)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmergencyContactName2)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmergencyContactNumber1)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmergencyContactNumber2)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberFullName)
                    .HasColumnType("varchar(512)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberGender)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberHash)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberHomeAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberHomeLatitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberHomeLongitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberHomePhoneNumber)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberIdnumber)
                    .HasColumnName("HaloMemberIDNumber")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberIdtype)
                    .HasColumnName("HaloMemberIDType")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberImage)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberIsHashed)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.HaloMemberLanguage)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLoadDate)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloMemberMedicalAidName)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberMedicalAidNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberMedicalAidScheme)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberModifiedDate).HasColumnType("timestamp");

                entity.Property(e => e.HaloMemberName)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberOccupation)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberOtp)
                    .HasColumnName("HaloMemberOTP")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberPassword)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.HaloMemberSurname)
                    .HasColumnType("varchar(400)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberToken)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberVat)
                    .HasColumnType("varchar(31)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberWelcomeEmailSent)
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HaloMemberWorkAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberWorkPhoneNumber)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halomembersstage>(entity =>
            {
                entity.HasKey(e => e.HaloMemberId)
                    .HasName("PRIMARY");

                entity.ToTable("halomembersstage");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberActive)
                    .HasColumnType("smallint(1)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.HaloMemberAllergies)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberBloodDonorNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberBloodType)
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberBusinessName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberDateOfBirth)
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmailAddress)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmergencyContactName1)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmergencyContactName2)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmergencyContactNumber1)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberEmergencyContactNumber2)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberGender)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberHomeAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberHomeLatitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberHomeLongitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberHomePhoneNumber)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberIdnumber)
                    .HasColumnName("HaloMemberIDNumber")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberIdtype)
                    .HasColumnName("HaloMemberIDType")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberImage)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberLanguage)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberMedicalAidName)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberMedicalAidNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberMedicalAidScheme)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberOccupation)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberOtp)
                    .HasColumnName("HaloMemberOTP")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberPassword)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.HaloMemberSurname)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberToken)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberWorkAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberWorkPhoneNumber)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halomobileclientcontent>(entity =>
            {
                entity.ToTable("halomobileclientcontent");

                entity.Property(e => e.HaloMobileClientContentId)
                    .HasColumnName("HaloMobileClientContentID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMobileClientContentClientId)
                    .HasColumnName("HaloMobileClientContentClientID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMobileClientContentPageContent)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMobileClientContentPageName)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halomobilecontent>(entity =>
            {
                entity.ToTable("halomobilecontent");

                entity.Property(e => e.HaloMobileContentId)
                    .HasColumnName("HaloMobileContentID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloMobileContentPageContent)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMobileContentPageName)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMobileContentType)
                    .HasColumnType("varchar(36)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halonetstar>(entity =>
            {
                entity.ToTable("halonetstar");

                entity.Property(e => e.HaloNetStarId)
                    .HasColumnName("HaloNetStarID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloNetStarCellNumber)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloNetStarIdnumber)
                    .HasColumnName("HaloNetStarIDNumber")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloNetStarIncidentDateTimeUtc)
                    .HasColumnName("HaloNetStarIncidentDateTimeUTC")
                    .HasColumnType("varchar(25)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloNetStarIncidentLatitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloNetStarIncidentLongitude)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloNetStarIncidentSpeed)
                    .HasColumnType("varchar(3)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloNetStarName)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloNetStarPolicyNumber)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloNetStarSurname)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloNetStarTimeStamp)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloNetStarVehichleRegistration)
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halopanics>(entity =>
            {
                entity.HasKey(e => e.HaloPanicId)
                    .HasName("PRIMARY");

                entity.ToTable("halopanics");

                entity.Property(e => e.HaloPanicId)
                    .HasColumnName("HaloPanicID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloCaseId)
                    .HasColumnName("HaloCaseID")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberPhoneNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPanicActive).HasDefaultValueSql("'1'");

                entity.Property(e => e.HaloPanicHandledAt).HasColumnType("timestamp");

                entity.Property(e => e.HaloPanicHandledBy).HasColumnType("bigint(20)");

                entity.Property(e => e.HaloPanicLatitude)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPanicLongitude)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPanicProductId)
                    .HasColumnName("HaloPanicProductID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloPanicTimeStamp)
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloPanicVmiId)
                    .HasColumnName("HaloPanicVmiID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halopartners>(entity =>
            {
                entity.HasKey(e => e.HaloPartnerId)
                    .HasName("PRIMARY");

                entity.ToTable("halopartners");

                entity.Property(e => e.HaloPartnerId)
                    .HasColumnName("HaloPartnerID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloPartnerAbout)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPartnerEmailAddress)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPartnerLogoPath)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("'/images/partners/default/logo.png'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPartnerName)
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPartnerPhoneNumbers)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPartnerPhysicalAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPartnerPostalAddress)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloPartnerWebsite)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Haloproducts>(entity =>
            {
                entity.HasKey(e => e.HaloProductId)
                    .HasName("PRIMARY");

                entity.ToTable("haloproducts");

                entity.Property(e => e.HaloProductId)
                    .HasColumnName("HaloProductID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloProductDescription)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloProductIcon)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloProductName)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloProductPhoneNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloProductPrice).HasColumnType("decimal(8,2)");

                entity.Property(e => e.HaloProductTerms)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Haloreminders>(entity =>
            {
                entity.ToTable("haloreminders");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.InAppMessageId)
                    .HasColumnName("in_app_message_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ReferenceNumber)
                    .HasColumnName("reference_number")
                    .HasColumnType("varchar(30)")
                    .HasComment(@"Uniqe identifier of the reminder
vehicle licence - registration number
drivers licence - licence number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReminderType)
                    .HasColumnName("reminder_type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Halosentsmss>(entity =>
            {
                entity.HasKey(e => e.HaloSentSmsid)
                    .HasName("PRIMARY");

                entity.ToTable("halosentsmss");

                entity.Property(e => e.HaloSentSmsid)
                    .HasColumnName("HaloSentSMSID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloSentSmsfromId)
                    .HasColumnName("HaloSentSMSFromID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloSentSmsgatewayResponse)
                    .HasColumnName("HaloSentSMSGatewayResponse")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloSentSmsmessage)
                    .HasColumnName("HaloSentSMSMessage")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloSentSmstimeStamp)
                    .HasColumnName("HaloSentSMSTimeStamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HaloSentSmstoId)
                    .HasColumnName("HaloSentSMSToID")
                    .HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<Halositeconfig>(entity =>
            {
                entity.ToTable("halositeconfig");

                entity.Property(e => e.HaloSiteConfigId)
                    .HasColumnName("HaloSiteConfigID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HaloSiteConfigKey)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloSiteConfigValue)
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halovehiclelicences>(entity =>
            {
                entity.HasKey(e => e.HaloVehicleLicenceId)
                    .HasName("PRIMARY");

                entity.ToTable("halovehiclelicences");

                entity.HasIndex(e => e.HaloMemberId)
                    .HasName("fk_HaloVehicleLicences_1_idx");

                entity.Property(e => e.HaloVehicleLicenceId)
                    .HasColumnName("HaloVehicleLicenceID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ControlNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EngineNumber)
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HaloDependantId)
                    .HasColumnName("HaloDependantID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.HaloMemberId)
                    .HasColumnName("HaloMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.LicenceNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegisterNumber)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SeriesName)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VehicleColour)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VehicleDescription)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VehicleMake)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VehicleYear)
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VinNumber)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Halovehiclemonitorintegration>(entity =>
            {
                entity.HasKey(e => e.Vmiid)
                    .HasName("PRIMARY");

                entity.ToTable("halovehiclemonitorintegration");

                entity.Property(e => e.Vmiid)
                    .HasColumnName("VMIID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.VmicellNumber)
                    .HasColumnName("VMICellNumber")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vmiidnumber)
                    .HasColumnName("VMIIDNumber")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VmiincidentDateTimeUtc)
                    .HasColumnName("VMIIncidentDateTimeUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.VmiincidentLatitude)
                    .HasColumnName("VMIIncidentLatitude")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VmiincidentLongitude)
                    .HasColumnName("VMIIncidentLongitude")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VmiincidentSpeed)
                    .HasColumnName("VMIIncidentSpeed")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VmimemberId)
                    .HasColumnName("VMIMemberID")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Vminame)
                    .HasColumnName("VMIName")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VmipolicyNumber)
                    .HasColumnName("VMIPolicyNumber")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vmiradius)
                    .HasColumnName("VMIRadius")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vmisource)
                    .HasColumnName("VMISource")
                    .HasColumnType("varchar(32)")
                    .HasDefaultValueSql("'cartrack'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Vmistatus)
                    .HasColumnName("VMIStatus")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Vmisurname)
                    .HasColumnName("VMISurname")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VmitimeStamp)
                    .HasColumnName("VMITimeStamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.VmivehichleRegistration)
                    .HasColumnName("VMIVehichleRegistration")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Inappnotificationclientdetails>(entity =>
            {
                entity.ToTable("inappnotificationclientdetails");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.HaloClientId)
                    .HasColumnName("halo_client_id")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.NotificationTitle)
                    .HasColumnName("notification_title")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OnesignalToken)
                    .HasColumnName("onesignal_token")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("notifications");

                entity.HasIndex(e => e.Id)
                    .HasName("notifications_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content")
                    .HasColumnType("longtext")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Program)
                    .HasColumnName("program")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Sent)
                    .HasColumnName("sent")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Otplogin>(entity =>
            {
                entity.ToTable("otplogin");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatedDateUtc).HasColumnType("datetime");

                entity.Property(e => e.IsValid)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NotificationType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.OtpCode)
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OtpType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TenantId)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId).HasColumnType("int(11)");

                entity.Property(e => e.UserKey)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Policychangerequests>(entity =>
            {
                entity.ToTable("policychangerequests");

                entity.HasIndex(e => e.Id)
                    .HasName("PolicyChangeRequests_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChangeDetails)
                    .HasColumnName("change_details")
                    .HasColumnType("varchar(1023)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PolicyId)
                    .HasColumnName("policy_id")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RequestTimestamp)
                    .HasColumnName("request_timestamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.RiskItemId)
                    .HasColumnName("risk_item_id")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("bigint(20)")
                    .HasComment("Currently HaloMemberID ");
            });

            modelBuilder.Entity<Policytestids>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("policytestids");

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasColumnName("id_number")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ProductIcons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product_icons");

                entity.HasIndex(e => e.ProductIconName)
                    .HasName("product_icons_product_icon_name_uindex")
                    .IsUnique();

                entity.Property(e => e.ProductIconFile)
                    .HasColumnName("product_icon_file")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ProductIconName)
                    .IsRequired()
                    .HasColumnName("product_icon_name")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Providers>(entity =>
            {
                entity.HasKey(e => e.ProviderId)
                    .HasName("PRIMARY");

                entity.ToTable("providers");

                entity.HasIndex(e => e.ProviderId)
                    .HasName("providers_provider_id_uindex")
                    .IsUnique();

                entity.Property(e => e.ProviderId)
                    .HasColumnName("provider_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.BankAccNumber)
                    .HasColumnName("bank_acc_number")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.BankBranchCode)
                    .HasColumnName("bank_branch_code")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.BankName)
                    .HasColumnName("bank_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.BranchPhysicalAddress)
                    .HasColumnName("branch_physical_address")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.BusinessRegistrationNumber)
                    .HasColumnName("business_registration_number")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IncomTaxNumber)
                    .HasColumnName("incom_tax_number")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OwnerContactNumber)
                    .HasColumnName("owner_contact_number")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.OwnerName)
                    .HasColumnName("owner_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PostalAddress)
                    .HasColumnName("postal_address")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.PrimaryContactNumber)
                    .HasColumnName("primary_contact_number")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RegisteredBusinessName)
                    .HasColumnName("registered_business_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.RegisteredPhysicalAddress)
                    .HasColumnName("registered_physical_address")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SecondaryContactNumber)
                    .HasColumnName("secondary_contact_number")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Suburb)
                    .HasColumnName("suburb")
                    .HasColumnType("varchar(64)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TradingBusinessName)
                    .HasColumnName("trading_business_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.VatNumber)
                    .HasColumnName("vat_number")
                    .HasColumnType("varchar(16)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Provinces>(entity =>
            {
                entity.HasKey(e => e.ProvinceId)
                    .HasName("PRIMARY");

                entity.ToTable("provinces");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("province_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("province_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvinceDescription)
                    .HasColumnName("province_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProvinceName)
                    .HasColumnName("province_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Provincescol)
                    .HasColumnName("provincescol")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ProvincesList>(entity =>
            {
                entity.ToTable("provinces_list");

                entity.HasIndex(e => e.ProvincesListId)
                    .HasName("provinces_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ProvincesListId)
                    .HasColumnName("provinces_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvincesListDescription)
                    .HasColumnName("provinces_list_description")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ProvincesListName)
                    .HasColumnName("provinces_list_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ReferenceSubset>(entity =>
            {
                entity.ToTable("reference_subset");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubsetLast)
                    .HasColumnName("subset_last")
                    .HasColumnType("varchar(3)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SubsetName)
                    .HasColumnName("subset_name")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SubsetPrefix)
                    .HasColumnName("subset_prefix")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ReferralResponse>(entity =>
            {
                entity.ToTable("referral_response");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreateAt)
                    .HasColumnName("create_at")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.HttpResponse)
                    .HasColumnName("http_response")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Referrals>(entity =>
            {
                entity.ToTable("referrals");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.MemberId)
                    .HasColumnName("member_id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(1024)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .HasColumnType("varchar(32)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("refresh_token");

                entity.HasIndex(e => e.AuthTokenId)
                    .HasName("refresh_token_auth_token_id_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("refresh_token_id_uindex")
                    .IsUnique();

                entity.Property(e => e.AuthTokenId)
                    .IsRequired()
                    .HasColumnName("auth_token_id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("expiration_date")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Revoked)
                    .HasColumnName("revoked")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("region");

                entity.HasIndex(e => e.RegionId)
                    .HasName("region_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.RegionId)
                    .HasColumnName("region_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("province_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegionDescription)
                    .HasColumnName("region_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegionName)
                    .HasColumnName("region_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<RegionList>(entity =>
            {
                entity.ToTable("region_list");

                entity.HasIndex(e => e.RegionListId)
                    .HasName("region_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.RegionListId)
                    .HasColumnName("region_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RegionListDescription)
                    .HasColumnName("region_list_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RegionListName)
                    .HasColumnName("region_list_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ServiceCatagoriesList>(entity =>
            {
                entity.ToTable("service_catagories_list");

                entity.HasIndex(e => e.ServiceCatagoriesListId)
                    .HasName("service_catagories_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceCatagoriesListId)
                    .HasColumnName("service_catagories_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceCatagoriesListDescription)
                    .HasColumnName("service_catagories_list_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceCatagoriesListName)
                    .HasColumnName("service_catagories_list_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ServiceCategories>(entity =>
            {
                entity.HasKey(e => e.ServiceCatagorieId)
                    .HasName("PRIMARY");

                entity.ToTable("service_categories");

                entity.HasIndex(e => e.ServiceCatagorieId)
                    .HasName("service_catagorie_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceCatagorieId)
                    .HasColumnName("service_catagorie_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceCategorieDescription)
                    .HasColumnName("service_categorie_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ServiceCategorieName)
                    .HasColumnName("service_categorie_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<ServiceList>(entity =>
            {
                entity.ToTable("service_list");

                entity.HasIndex(e => e.ServiceListId)
                    .HasName("service_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceListId)
                    .HasColumnName("service_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceListDescription)
                    .HasColumnName("service_list_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceListName)
                    .HasColumnName("service_list_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ServiceProvidersAudit>(entity =>
            {
                entity.ToTable("service_providers_audit");

                entity.HasComment("Sercive providers audit file");

                entity.HasIndex(e => e.ServiceProvidersAuditId)
                    .HasName("service_providers_audit_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceProvidersAuditId)
                    .HasColumnName("service_providers_audit_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceProvidersAuditChangeDate)
                    .HasColumnName("service_providers_audit_change_date")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceProvidersAuditChangedTableName)
                    .HasColumnName("service_providers_audit_changed_table_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceProvidersAuditData)
                    .HasColumnName("service_providers_audit_data")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceProvidersAuditType)
                    .HasColumnName("service_providers_audit_type")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ServiceProvidersAuditUserName)
                    .HasColumnName("service_providers_audit_user_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<ServiceSubCatagories>(entity =>
            {
                entity.HasKey(e => e.ServiceSubCatagorieId)
                    .HasName("PRIMARY");

                entity.ToTable("service_sub_catagories");

                entity.HasIndex(e => e.ServiceSubCatagorieId)
                    .HasName("service_sub_catagorie_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceSubCatagorieId)
                    .HasColumnName("service_sub_catagorie_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceCatagorieId)
                    .HasColumnName("service_catagorie_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceSubCatagorieDescription)
                    .HasColumnName("service_sub_catagorie_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ServiceSubCatagorieName)
                    .HasColumnName("service_sub_catagorie_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<ServiceSubCategoriesList>(entity =>
            {
                entity.ToTable("service_sub_categories_list");

                entity.HasIndex(e => e.ServiceSubCategoriesListId)
                    .HasName("service_sub_categories_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceSubCategoriesListId)
                    .HasColumnName("service_sub_categories_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceSubCategoriesListDescription)
                    .HasColumnName("service_sub_categories_list_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ServiceSubCategoriesListName)
                    .HasColumnName("service_sub_categories_list_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Serviceprovider>(entity =>
            {
                entity.ToTable("serviceprovider");

                entity.HasIndex(e => e.BillingAddressId)
                    .HasName("FK_ServiceProvider_Address_BillingAddressId");

                entity.HasIndex(e => e.PhysicalAddressId)
                    .HasName("FK_ServiceProvider_Address_PhysicalAddressId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Active).HasColumnType("int(11)");

                entity.Property(e => e.BillingAddressId).HasColumnType("int(11)");

                entity.Property(e => e.CompanyEmail)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactPersonName)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedOnUtc)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Deleted).HasColumnType("int(11)");

                entity.Property(e => e.IncomeTaxNumber)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnersName)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhysicalAddressId).HasColumnType("int(11)");

                entity.Property(e => e.RegisteredBusinessName)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SystemDefault).HasColumnType("int(11)");

                entity.Property(e => e.Telephone)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TradingBusinessName)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedOnUtc)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VatNumber)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WebSite)
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.ServiceproviderBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("FK_ServiceProvider_Address_BillingAddressId");

                entity.HasOne(d => d.PhysicalAddress)
                    .WithMany(p => p.ServiceproviderPhysicalAddress)
                    .HasForeignKey(d => d.PhysicalAddressId)
                    .HasConstraintName("FK_ServiceProvider_Address_PhysicalAddressId");
            });

            modelBuilder.Entity<ServiceproviderTenantMapping>(entity =>
            {
                entity.ToTable("serviceprovider_tenant_mapping");

                entity.HasIndex(e => e.ServiceproviderId)
                    .HasName("FK_smmap_ServiceproviderId_serviceproviderId_idx");

                entity.HasIndex(e => e.TenantId)
                    .HasName("FK_spmap_tenantid_tenantId_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsPreferred)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.ServiceproviderId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tenant)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("'786931ff-d775-4606-b5ec-aef26e3f7420'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TenantId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Serviceprovider)
                    .WithMany(p => p.ServiceproviderTenantMapping)
                    .HasForeignKey(d => d.ServiceproviderId)
                    .HasConstraintName("FK_smmap_ServiceproviderId_serviceproviderId");

                entity.HasOne(d => d.TenantNavigation)
                    .WithMany(p => p.ServiceproviderTenantMapping)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_spmap_tenantid_tenantId");
            });

            modelBuilder.Entity<Serviceprovideraddress>(entity =>
            {
                entity.ToTable("serviceprovideraddress");

                entity.HasIndex(e => e.AddressId)
                    .HasName("FK_ServiceProviderAddress_Address_AddressId");

                entity.HasIndex(e => e.ServiceProviderId)
                    .HasName("FK_ServiceProviderAddress_ServiceProvider_ServiceProviderId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AddressId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DisplayOrder)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ServiceProviderId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Serviceprovideraddress)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_ServiceProviderAddress_Address_AddressId");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.Serviceprovideraddress)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_ServiceProviderAddress_ServiceProvider_ServiceProviderId");
            });

            modelBuilder.Entity<Serviceprovidercategory>(entity =>
            {
                entity.ToTable("serviceprovidercategory");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("FK_ServiceProviderCategory_Category_CategoryId");

                entity.HasIndex(e => e.ServiceProviderId)
                    .HasName("FK_ServiceProviderCategory_ServiceProvider_ServiceProviderId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CategoryId).HasColumnType("int(11)");

                entity.Property(e => e.DisplayOrder).HasColumnType("int(11)");

                entity.Property(e => e.IsFeaturedProduct).HasColumnType("int(11)");

                entity.Property(e => e.ServiceProviderId).HasColumnType("int(11)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Serviceprovidercategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ServiceProviderCategory_Category_CategoryId");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.Serviceprovidercategory)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_ServiceProviderCategory_ServiceProvider_ServiceProviderId");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PRIMARY");

                entity.ToTable("services");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("service_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ServiceId)
                    .HasColumnName("service_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProviderId)
                    .HasColumnName("provider_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServiceDescription)
                    .HasColumnName("service_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.ServiceName)
                    .HasColumnName("service_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Suburbs>(entity =>
            {
                entity.HasKey(e => e.SuburbId)
                    .HasName("PRIMARY");

                entity.ToTable("suburbs");

                entity.HasIndex(e => e.SuburbId)
                    .HasName("suburb_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.SuburbId)
                    .HasColumnName("suburb_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Address1)
                    .HasColumnName("address_1")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnName("address_2")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BeeLevel)
                    .HasColumnName("bee_level")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BranchEmailAddress)
                    .HasColumnName("branch_email_address")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BranchLatitude)
                    .HasColumnName("branch_latitude")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BranchLongitude)
                    .HasColumnName("branch_longitude")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BranchTelephoneNumber)
                    .HasColumnName("branch_telephone_number")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactCellNo)
                    .HasColumnName("contact_cell_no")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactEmailAddress)
                    .HasColumnName("contact_email_address")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ContactName)
                    .HasColumnName("contact_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreditCheck)
                    .HasColumnName("credit_check")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateBeeLevel)
                    .HasColumnName("date_bee_level")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateCreditCheck)
                    .HasColumnName("date_credit_check")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SuburbName)
                    .HasColumnName("suburb_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<SuburbsList>(entity =>
            {
                entity.ToTable("suburbs_list");

                entity.HasIndex(e => e.SuburbsListId)
                    .HasName("suburbs_list_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.SuburbsListId)
                    .HasColumnName("suburbs_list_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SuburbsListDescription)
                    .HasColumnName("suburbs_list_description")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SuburbsListName)
                    .HasColumnName("suburbs_list_name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.ToTable("tenant");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.ClientCode)
                    .HasColumnType("varchar(45)")
                    .HasDefaultValueSql("'GC'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DataKey)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Database)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DbConnectionString)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HostNames)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsEnabled).HasColumnType("int(11)");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.Logo)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ParentItemId).HasColumnType("int(11)");

                entity.Property(e => e.Password)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Salt)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Server)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subscription).HasColumnType("int(11)");

                entity.Property(e => e.SubscriptionExipreDate).HasColumnType("datetime");

                entity.Property(e => e.SubscriptionType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TenantId)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Theme)
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserName)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.HasKey(e => e.AutoInc)
                    .HasName("PRIMARY");

                entity.ToTable("token");

                entity.HasIndex(e => e.Id)
                    .HasName("token_id_uindex")
                    .IsUnique();

                entity.Property(e => e.AutoInc)
                    .HasColumnName("auto_inc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Issuer)
                    .HasColumnName("issuer")
                    .HasColumnType("varchar(128)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<UserClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user_client");

                entity.HasIndex(e => e.Id)
                    .HasName("user_client_id_uindex")
                    .IsUnique();

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.AutoInc)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.HasIndex(e => e.Email)
                    .HasName("users_email_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("users_id_uindex")
                    .IsUnique();

                entity.Property(e => e.AutoInc)
                    .HasColumnName("auto_inc")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(1023)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LastModified)
                    .HasColumnName("last_modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Secret)
                    .HasColumnName("secret")
                    .HasColumnType("varchar(36)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Ussdtest>(entity =>
            {
                entity.ToTable("ussdtest");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contents)
                    .HasColumnName("contents")
                    .HasColumnType("varchar(1023)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
