﻿using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.SeedData
{
    public static class JobSeedData
    {
        public static List<Job> GetSeedData()
        {

            return new List<Job>()
            {
                new Job{Id=1,Title="Bilgi İşlem Stajyeri ( Veri Merkezi )",TypeOfWork=1 ,YearsOfExperience=1 ,WorkPlace=1 ,StartDate=DateTime.Parse("2024-12-13") ,Content="İlan Özeti\r\n28.11.2024 tarihinde Turkcell Global Bilgi tarafından yayınlanan Bilgi İşlem Stajyeri ( Veri Merkezi ) iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan Kocaeli / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyimsiz arasında değişmektedir. Pozisyon Stajyer ve çalışma konumu İş Yerinde olarak belirlenmiştir. Turkcell Global Bilgi bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\nVeri Merkezi\r\nBilgi İşlem\r\nIT\r\nOnsıte", Description="İlan Açıklaması\r\nİş Tanımı\r\n\r\nSorumlusu olduğu Veri Merkezi’nde beyaz alan operasyonunun gerçekleştirmesi,\r\nSunucu/storage/appliance/FW ve benzeri veri merkezi altyapı ekipmanlarının fiziksel montaj ve demontajlarının gerçekleştirilmesi,\r\nVeri merkezindeki problemlere müdahale edilmesi, fiziksel kablolama ve patch yapılması,\r\nVeri merkezlerindeki izleme altyapısının (enerji, ısı, nem) takip edilmesi, mevcut enerji ve fiziksel alanın yönetilmesi,\r\nVeri merkezi içinde müşteri kurulumlarına eşlik edilmesi.",Skills="Genel Nitelikler\r\n\r\nÜniversitelerin Bilgisayar Programcılığı Elektronik Haberleşme Bilgisayar Teknolojileri vb ,  bölümlerde öğrenimi devam eden,\r\nZorunlu üniversite stajı olan ve SGK ödemesi okulu tarafından yapılan,\r\n2025 bahar dönemi zorunlu stajı olan,\r\nTurkcell Gebze , Ankara , Tekirdağ Veri Merkezinde haftanın en az 3 günü staja devam edebilecek,\r\nMS Office programlarına hakim,\r\nİnsan ilişkileri kuvvetli, ekip çalışmasına yatkın,\r\nEnerjik, sorumluluk sahibi, öğrenmeye açık,\r\nTakip ve koordinasyon yeteneği güçlü,\r\nUlaşım problemi olmayan ,\r\nBilgi Teknolojileri dünyasına ilgi duyan ve bu alandaki gelişmeleri heyecanla takip eden,\r\nİşletme de Mesleki Eğitim Staj Programı olan ya da Zorunlu Stajı olan adayların başvuruları değerlendirmeye alınacaktır.", CompanyId=1 },
                new Job{Id=2,Title="Yazılım Geliştirme Takım Lideri",TypeOfWork=2 ,YearsOfExperience=2 ,WorkPlace=2 ,StartDate=DateTime.Parse("2024-11-28") ,Content="İlan Özeti\r\n28.11.2024 tarihinde GLOBALPBX İLETİŞİM TEKNOLOJİLERİ ANONİM ŞİRKETİ tarafından yayınlanan Yazılım Geliştirme Takım Lideri iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan Ankara / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyim: 4-6 Yıl arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu Hibrit olarak belirlenmiştir. GLOBALPBX İLETİŞİM TEKNOLOJİLERİ ANONİM ŞİRKETİ bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\nagile\r\nscrum\r\nmvvm\r\nJava\r\nJavaScript\r\nReact.Js\r\nReact Native\r\nReact\r\nreact native\r\nsprint boot\r\njava\r\nlinux\r\nubuntu\r\ndevops\r\npython\r\nreactjs", Description="İlan Açıklaması\r\nYazılım Geliştirme Takım Lideri, yazılım geliştirme süreçlerini yöneten ve takımın performansını artırmak için liderlik eden bir pozisyondur. Bu pozisyon, teknik bilgi birikimi olan ve ekip yönetimi konusunda deneyimli bir profesyoneli gerektirir.",Skills="Genel Nitelikler\r\n\r\nÜniversitelerin (Örgün Eğitim) Bilgisayar, Elektrik-Elektronik, Enformatik, Yazılım, Bilişim, İletişim mühendislik bölümlerinden ve eşdeğer bölümlerden mezun, \r\nEn az 2 yıl takım yönetmiş, yazılım ekibine takım liderliği yapabilecek,\r\nAgile, Scrum, Kanban metodojilerine yabancı olmayan,\r\nEkip üyelerini motive ederek, gelişimlerini destekleyen ve hedeflere ulaşmalarını sağlayan liderlik becerisine sahip,\r\nŞirket vizyonunu ekibe aktararak, süreçleri iyileştiren ve stratejik kararlarla yönlendiren,\r\nAçık iletişim, yapıcı geri bildirim ve çözüm odaklı yaklaşım ile ekip içi uyumu sağlayan.\r\nDesign Pattern (MVVM, MVC, Observer, Factory, Singleton) konusunda ileri düzeyde bilgi sahibi,\r\nJava dili, mikro servis, backend uygulamaları hakkında ileri düzeyde bilgi sahibi,\r\nLinux (Ubuntu ve Debian) işletim sistemleri hakkında bilgi sahibi,\r\nStatik kod analizi (SonarQube vb.) araçlarından birini kullanmış,\r\nReact,ReactJs,Javascript vb. kütüphaneleri kullanmış,\r\nTercihen DevOps süreçleri hakkında bilgisi olan,\r\nTercihen en az bir projesinde test kütüphanelerini kullanmış olan,\r\nNesneye dayalı(OOP) tasarım ve programlamaya ileri düzeyde hakim,\r\nGüvenli yazılım geliştirme konusunda bilgisi olan,\r\nKatmanlı sistem ve yazılım mimarisi konusuna hakim olan,\r\nDökümanlar ve yardımcı uygulamaları anlayabilecek seviyede İngilizce bilgisi olan,\r\nKod okunabilirliği, yazılım standartları, kod dökümantasyonu gibi konulara önem veren,\r\nAnalitik düşünen, yaptığı işi sahiplenen ve sonuca götüren bir ekip arkadaşı aramaktayız.", CompanyId=2 },
                new Job{Id=3,Title="Embedded Software Engineer",TypeOfWork=3,YearsOfExperience=2 ,WorkPlace=2,StartDate=DateTime.Parse("2024-11-28") ,Content="İlan Özeti\r\n28.11.2024 tarihinde Panasonic Electric Works Türkiye tarafından yayınlanan Embedded Software Engineer iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan İstanbul(Asya) / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyim: 2-4 Yıl arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu Hibrit olarak belirlenmiştir. Panasonic Electric Works Türkiye bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\nC\r\nC++", Description="Job Description:\r\n\r\nDesigning new products or improving existing products considering the market and customer needs by developing software\r\nImplementing unit, integration, system and production tests\r\nContributing nationally/internationally funded R&D projects\r\nProducing high quality project deliverables within planned time and effort\r\nFollowing coding conventions and best practices, participating code review activities\r\nActively contributing to the agile development ceremonies (sprint planning, daily stand-up, sprint review and sprint retrospective)\r\nConducting thorough testing and debugging to ensure the reliability and stability of embedded software solutions\r\nCollaborating with hardware engineers to ensure seamless integration between software and hardware components",Skills="General Qualifications:\r\n\r\nMinimum bachelor’s degree in electronics engineering, computer engineering, automation engineering or a related area\r\nTeamwork prone, strong communication, follow-up and problem-solving skills\r\n2+ years software development experience and strong knowledge with C/C++\r\nExperience in design patterns and object-oriented software development\r\nExperience with debugging tools and techniques for embedded systems\r\nFamiliarity with software version control systems (e.g., Git) and issue tracking systems (e.g., JIRA)\r\nProactive attitude towards learning and adapting to new technologies\r\nExcellent command of written and spoken English\r\nPreferred Qualifications:\r\n\r\nExperience with communication protocols such as KNX, DALI, TCP/IP, Modbus, G3-PLC\r\nExperience with other high level programming languages (e.g. C#, JavaScript, Python, etc.)\r\nExperience in the development of smart home or IoT devices\r\nEmbedded software development experience with operating systems (i.e. RTOS, Linux) is preferred", CompanyId=3 },
                new Job{Id=4,Title="SSD Firmware Engineer",TypeOfWork=3,YearsOfExperience=3,WorkPlace=2,StartDate=DateTime.Parse("2024-11-27") ,Content="İlan Özeti\r\n27.11.2024 tarihinde Samsung tarafından yayınlanan SSD Firmware Engineer iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan Hindistan konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyim: 4-6 Yıl arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu Hibrit olarak belirlenmiştir. Samsung bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\nC/C++\r\nPerl\r\nPython\r\nShell\r\nFIO\r\nTCP\r\nRDMA", Description="Position Summary\r\n\r\nRole and Responsibilities\r\n\r\nAbout Samsung Semiconductor India Research (SSIR)\r\n\r\nWith a wide range of industry-leading semiconductor solutions, we are enabling innovative growth in market segments in component solutions, featuring industry-leading technologies in System LSI, Memory and Foundry. Our engineers are offered a foundation to work on cutting-edge technologies such as Foundation IP Design, Mobile SoCs, Storage Solutions, AI/ML, 5G/ 6G solutions, Neural processors, Serial Interfaces, Multimedia IPs and much more.\r\n\r\nAs one of the largest R&D centers outside Korea for Samsung Electronics, we take pride in our ability to work on some of the cutting edge technologies. Our engineers get to work across diverse domains, projects, products, clients, people and countries, and conduct research in new and emerging technology areas. Innovation and creativity are highly valued at this innovation hub, as we strive towards providing high reliability; high performance and value added services that enable Samsung Electronics deliver world-class products.",Skills="Roles and Responsibilities\r\n\r\nSound knowledge and hands-on experience in distributed storage system solution development\r\nDesign and development of next generation SSD scale out storage systems\r\nDevelopment of storage system features including but not limited to distribution, scaling, fail over protection, high availability, fast data path management and control plane\r\nDesign/Optimize the distribute storage system for new age storage devices\r\nDeployment of scale out solution with different use case and cluster topologies\r\nDesign & fast-paced development towards new ideas pertaining to Host/Storage co-design & vertical-optimizations.\r\nDevelopment/customization in the Linux I/O stack, file-systems, Block layer, NVMe driver, SPDK, DPDK, FIO, nvme-cli.\r\nSystem performance benchmarking, analysis and optimization\r\nUnit & integration test framework development and automation.\r\nTrouble shooting complex issues including but not limited to scalability & performance issues, memory leaks, memory corruption and kernel panics\r\nTechnical Leadership in design, planning, Framework development, implementation, unit and integration testing\r\nOpen-source development and contribution\r\nDrive innovation by authoring whitepapers, new technical proposals, conducting POCs and introducing new techniques for issue debugging.\r\nMentoring development team by conducting knowledge sharing sessions and trainings.\r\nPropose and present new ideas and concepts to improve products features, performance and quality.\r\nKeep abreast of changes in product architecture/design as well as developments in the related domain/technology.\r\nUnderstanding of Linux kernel stack, file systems, TCP IP stack\r\nExperience in developing the user mode storage software\r\nUnderstanding of RDMA, TCP-IP network protocols\r\nUnderstanding and hands-on experience implementing distribution algorithms, HA policies like replication and Erasure code, CAP theorem, failure over management\r\nUnderstanding of user space storage systems like SPDK, DPDK\r\nUnderstanding of interrupt and exception handling framework of Linux kernel\r\nUnderstanding of Linux kernel memory management and process memory subsystem interaction\r\nUnderstanding of server class CPU architecture and its internals\r\nTrouble shooting complex issues such as scalability & performance issues, memory leaks, memory corruption and Kernel panics\r\nStrong Programming Skills in High-level Languages (C/C++) and Scripting language (Perl/Python/Shell)\r\nExperience in planning, requirement analysis, design& development.\r\nTrouble shooting complex issues such as scalability & performance issues, memory leaks, memory corruption and Kernel panics\r\nGood understanding of product/automation frameworks, Hands on experience in using benchmarking tools (FIO, perf etc.)\r\nExcellent written and verbal communications skills. Good articulation skills\r\nDemonstrated team player and technical leader in a dynamic, fast moving and fast growing product development environment\r\nExperience – 4 to 16 Years\r\n\r\nQualifications\r\n\r\nB.Tech/B.E/M.Tech/M.E", CompanyId=4 },
                new Job{Id=5,Title="Cloud Engineer, SAP",TypeOfWork=3,YearsOfExperience=2,WorkPlace=2,StartDate=DateTime.Parse("2024-11-27") ,Content="İlan Özeti\r\n27.11.2024 tarihinde Google tarafından yayınlanan Cloud Engineer, SAP iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan Polonya konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyim: 4-6 Yıl arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu Hibrit olarak belirlenmiştir. Google bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\nAP HANA\r\nSAP Netweaver\r\nSolution Manager\r\nSAP Business Suite\r\nSAP Hybris\r\nBusiness Warehouse\r\nSAP\r\nBu becerilere sahip olmanız başvurunuzun dikkate alınma şansını artıracaktır.", Description="About the job\r\n\r\nAs a SAP Cloud Engineer, you will work directly with Google’s strategic customers on projects to provide management, consulting and technical advisory to customer engagements while working with client executives and technical leaders to deploy solutions on Google’s Cloud Platform.\r\n\r\nYou will work with Google's partners servicing customer accounts to manage projects, deliver consulting services, and provide technical guidance and best practice expertise. You will also travel approximately 25% of the time for client engagements.\r\n\r\nGoogle Cloud accelerates every organization’s ability to digitally transform its business and industry. We deliver enterprise-grade solutions that leverage Google’s cutting-edge technology, and tools that help developers build more sustainably. Customers in more than 200 countries and territories turn to Google Cloud as their trusted partner to enable growth and solve their most critical business problems.\r\n\r\nResponsibilities\r\n\r\nWork with customer technical leads, client executives, and partners to manage and deliver successful implementations of cloud solutions becoming a trusted advisor to decision makers throughout the engagement.\r\nWork with internal specialists, product and engineering teams to package best practices and lessons learned into thought leadership, methodologies and published assets.\r\nInteract with sales, partners, and customer technical stakeholders to manage project scope, priorities, deliverables, risks/issues, and timelines for successful client outcomes.\r\nAdvocate for customer needs in order to overcome adoption blockers and drive new feature development based on your field experience.\r\nPropose architectures for SAP products and manage the deployment of cloud based SAP solutions according to complex customer requirements and implementation best practices.",Skills="Minimum qualifications:\r\n\r\nBachelor's degree in Computer Science, Electrical Engineering, Computer Engineering, a related technical field, or equivalent practical experience.\r\n3 years of experience managing client-facing projects to completion.\r\nExperience troubleshooting clients technical issues while working with engineering teams, sales, services, and customers.\r\nExperience with SAP technologies (such as SAP HANA, SAP Netweaver, Solution Manager, SAP Business Suite, Business Warehouse, SAP Hybris, etc.), their architecture, and infrastructure.\r\nPreferred qualifications:\r\n\r\nMBA or Master's degree in Engineering, Computer Science, Data Science, or a related technical field.\r\nCertification in Google Cloud or similar.\r\n5 years of experience demonstrating technical client service.\r\nExperience with SAP Operating System and Database migrations, downtime optimizations, and backup strategies.\r\nExperience in SAP basis with direct implementing projects for live SAP environments on public cloud, and architecting around core production concepts (sizing, high availability, disaster recovery, multi-tenancy, scale out and scale up architectures, clustering, etc.).\r\nDemonstrate excellent communication, written, presentation, and problem-solving skills.", CompanyId=5 },
                new Job{Id=6,Title="Senior Full Stack Developer",TypeOfWork=3,YearsOfExperience=2,WorkPlace=2,StartDate=DateTime.Parse("2024-11-27") ,Content="İlan Özeti\r\n27.11.2024 tarihinde Büyük Savunma ve Yazılım Teknolojileri A.Ş. tarafından yayınlanan Senior Full Stack Developer iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan Ankara / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyim: 2-4 Yıl arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu Hibrit olarak belirlenmiştir. Büyük Savunma ve Yazılım Teknolojileri A.Ş. bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\nsql\r\ntypescript\r\njavascript\r\nreact\r\nagile\r\nscrum\r\ndocker\r\nkubernetes\r\nangular\r\n.Net Core\r\nBu becerilere sahip olmanız başvurunuzun dikkate alınma şansını artıracaktır.", Description="İlan Açıklaması\r\nJob description\r\n\r\nWe are looking for a Senior Level Full Stack Developer to join our team. This position works with business analysts, product owners and team members to utilize the Client's processes and requirements that drive the analysis and design of quality web-based technology solutions. The primary goal of the Full Stack Developer is to design, develop, troubleshoot, debug and implement software code (ASP.Net MVC/.Net Core, Angular, Web APIs /REST, SQL, TypeScript, and JavaScript).\r\n\r\n \r\n\r\nAbout Büyük Savunma Yazılım\r\n\r\nBüyük Savunma Yazılım started its activities in Ankara in 2019 in order to provide high-quality solutions to its business partners in the field of Information Technologies with its expert staff, management team and professional consultants in the field of Technology and Innovation. We are in search of a \"Senior Full Stack Developer\" to be employed in our young, dynamic and rapidly growing company.",Skills="In addition, we offer:\r\n\r\nChance of self-development at new technologies\r\nOpportunity to improve your technical skills in a learning supportive environment\r\nWe value you and your work, not ego or titles\r\nWorking with highly skilled peoples\r\nWorking in an area which is of great importance for Software Development\r\nA relaxed and fun team\r\nA full-time position (40-hour week)\r\nGreat training and education opportunities\r\n \r\n\r\nRequirements\r\n\r\nOver 4 years of Full Stack experience\r\nStrong experience with ASP.Net MVC/.Net Core\r\nExperience with Full Stack frameworks like Angular, React, or Node.js\r\nKnowledge of building and consuming RESTful APIs and Enterprise Level Web Applications and Restful Web Services\r\nAbility to work independently\r\nKnowledge using Databases for developing database objects such as tables, views, stored procedures, and functions\r\nExperience with Agile or Scrum methodologies\r\nStrong experience in continuous integration within DevOps environment\r\nGood to have experience in working with Git/JIRA\r\nGood to have experience in working with container technologies such as Docker, Kubernetes is a plus\r\nStrong experience in object-oriented design and development-Ability to manage multiple tasks and consistently meet established timelines\r\nExperience in the defense or software technology industry is a plus\r\nBeceriler\r\nsql\r\ntypescript\r\njavascript\r\nreact\r\nagile\r\nscrum\r\ndocker\r\nkubernetes\r\nangular\r\n.Net Core", CompanyId=6 },
                new Job{Id=7,Title="Yazılım Geliştirme Elemanı",TypeOfWork=3,YearsOfExperience=1,WorkPlace=3,StartDate=DateTime.Parse("2024-11-16") ,Content="İlan Özeti\r\n26.11.2024 tarihinde Hüroğlu Otomotiv San. Tic. A.Ş. tarafından yayınlanan Yazılım Geliştirme Elemanı iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan Bursa / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyim: 1-2 Yıl arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu İş Yerinde olarak belirlenmiştir. Hüroğlu Otomotiv San. Tic. A.Ş. bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\nsql\r\nservis\r\nc#", Description="İlan Açıklaması\r\nDepartmanların ihtiyaç duyduğu yazılım/makro uygulamalarının geliştirilmesi\r\nTalep edilen SQL yetkilendirme/sorgu/sunucu bakımlarını gerçekleştirecek\r\nBT teknolojileri ekipman ve yazılım sorunlar çözümü için gerekli destek hizmeti alınan firmalar ile iletişim sağlanması\r\nKullanılan dış kaynaklı yazılımların sağlayıcıları ile görüşmeler/servis talepleri",Skills="Beceriler\r\nsql\r\nservis\r\nc#", CompanyId=7},
                new Job{Id=8,Title="SEO & İş Geliştirme Analisti",TypeOfWork=3,YearsOfExperience= 1,WorkPlace=2,StartDate=DateTime.Parse("2024-11-22") ,Content="İlan Özeti\r\n22.11.2024 tarihinde ByNoGame® tarafından yayınlanan SEO & İş Geliştirme Analisti iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan İzmir / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyimsiz / Deneyimli arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu Hibrit olarak belirlenmiştir. ByNoGame® bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\nhtml\r\ncss\r\nseo\r\nArama Motoru Optimiz", Description="İlan Açıklaması\r\nSektörün lideri, yenilikçi yaklaşımı ve müşteri odaklı hizmetleriyle tanınan ByNoGame, merkez ofisimizde çalışmak üzere iş analizi konusunda bilgi sahibi ekip üyesi arıyoruz.\r\n \r\n\r\nİş Tanımı:\r\n\r\n • Şirket stratejilerine uygun olarak iş analizi yapmak ve raporlamalar hazırlamak.\r\n ",Skills="Aranan Nitelikler:\r\n\r\n • Üniversitelerin ilgili bölümlerinden mezun,\r\n\r\n • İş analizi konularında temel bilgi sahibi,\r\n\r\n • HTML, CSS gibi frontend teknolojilerine bilgi sahibi,\r\n\r\n • SEO konularında bilgi sahibi,\r\n\r\n • Güçlü iletişim becerilerine sahip; ekip çalışmasına yatkın,\r\n\r\n • Yeniliklere açık, öğrenmeye istekli...", CompanyId=8 },
                new Job{Id=9,Title="Yazılım Uzmanı",TypeOfWork=3,YearsOfExperience=2,WorkPlace=2,StartDate=DateTime.Parse("2024-11-05") ,Content="İlan Özeti\r\n05.11.2024 tarihinde Casper Bilgisayar Sistemleri A.Ş. tarafından yayınlanan Yazılım Uzmanı iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan İstanbul(Asya) / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyimsiz / Deneyimli arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu İş Yerinde olarak belirlenmiştir. Casper Bilgisayar Sistemleri A.Ş. bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\nphp\r\nlaravel\r\nc#\r\nmssql\r\nGithub\r\nHTML\r\nvue.js\r\ncss\r\nseo\r\njavascript\r\nmysql\r\n.Net\r\nweb\r\nandroid\r\nsoap\r\n.net\r\nCD\r\nfrontend\r\nbackend\r\nBu becerilere sahip olmanız başvurunuzun dikkate alınma şansını artıracaktır.", Description="İlan Açıklaması\r\n1991 yılında başlayan yolculuğumuzda, bugün ülkemizin teknolojide dünyadaki en önemli temsilcilerinden biri ve Türkiye'de dijital dönüşüme yön veren lider markalardan olmanın gururunu yaşıyoruz.\r\n\r\n Casper’da, tüm ürünlerimizin tasarım ve Ar-Ge süreçlerini kendi mühendislerimiz ile yürütüyoruz. Mobil cihazlar, bilgisayarlar ve bunlara ait donanımlar, yazılımlar konusunda ilham verici liderler ve destekleyici çalışma arkadaşları ile iş birliği yaparak, şirketimizin hem backend hem de frontend yazılımlarını geliştirme süreçlerinde aktif rol alacak, yenilikçi projelerimize katkı sağlayacak ve bizimle beraber keyifle çalışacak aşağıdaki özelliklere sahip bir “Yazılım Uzmanı” arıyoruz.\r\n\r\n \r\n\r\nİş Tanımı;\r\n\r\nBackend ve frontend yazılımlarının geliştirilmesi ve bakımını sağlamak,\r\nYazılım analizlerini gerçekleştirmek ve projelerin teknik gereksinimlerini belirlemek,\r\nKodlama süreçlerinde etkin rol almak ve en iyi uygulama yöntemlerini kullanmak,\r\nUygulama sonrası test süreçlerini yürütmek ve hataları tespit ederek çözüm üretmek,\r\nProjelerin teknik dokümantasyonunu hazırlamak ve sürekli güncel tutmak,\r\nEkip içi ve ekipler arası iletişimi güçlü tutarak iş birliği içinde çalışmak,\r\nYeni teknolojileri ve trendleri takip ederek projelere entegre etmek,\r\nKullanıcı deneyimini geliştirmek için geri bildirimleri değerlendirerek iyileştirmeler yapmak.",Skills=" Genel Nitelikler;\r\n\r\nÜniversitelerin ilgili lisans programlarından mezun,\r\nPHP ve Laravel framework konusunda tecrübeli,\r\nC# ve .NET platformunda geliştirme yapmış,\r\nMSSQL veya MySQL veri tabanlarında deneyimli,\r\nHTML, CSS ve JavaScript konularında bilgi sahibi,\r\nGit ve GitHub kullanarak proje geliştirmiş,\r\nGolang ile geliştirme yapmış,\r\nVue.js framework'ü ile çalışmış,\r\nE-ticaret siteleri geliştirme tecrübesi olan,\r\nSEO konusunda bilgi sahibi,\r\nWeb Servisleri (SOAP, REST) konusunda deneyimli,\r\nCI/CD süreçlerine hakim,\r\nTercihen Android geliştirmede deneyimli,\r\nDokümantasyon yeteneğine sahip, yaptığı işi yazılı hale getirmeyi seven,\r\nÖğrenmeye açık, kendini geliştirmeye istekli, analitik düşünme becerisine sahip,\r\nTercihen iyi seviyede ingilizce dil bilgisine sahip,\r\nİstanbul Anadolu yakasında ikamet eden,\r\nErkek adaylar için askerliğini tamamlamış.\r\nBeceriler\r\nphp\r\nlaravel\r\nc#\r\nmssql\r\nGithub\r\nHTML\r\nvue.js\r\ncss\r\nseo\r\njavascript\r\nmysql\r\n.Net\r\nweb\r\nandroid\r\nsoap\r\n.net\r\nCD\r\nfrontend\r\nbackend", CompanyId=9},
                new Job{Id=10,Title="Fullstack Developer",TypeOfWork=3,YearsOfExperience=4,WorkPlace=1,StartDate=DateTime.Parse("2024-11-28") ,Content="İlan Özeti\r\n28.11.2024 tarihinde Arvento Mobil Sistemler A.Ş. tarafından yayınlanan Fullstack Developer iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan Ankara / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyim: 2-4 Yıl arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu İş Yerinde olarak belirlenmiştir. Arvento Mobil Sistemler A.Ş. bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\ntelematics\r\nasp.net\r\nrestful\r\ncore\r\nsoftware\r\nc#\r\nsql\r\ndocker\r\nBu becerilere sahip olmanız başvurunuzun dikkate alınma şansını artıracaktır.", Description="Job Description\r\n \r\nThe position offers an engineer the opportunity to make major contributions to Arvento’s products and projects. The responsibilities of this position include designing, development and maintenance of software application and database to satisfy business requirements. It requires ability to follow the product development processes to ensure high quality and maintainability of the work, interface with internal and external customers as required to understand their requirements and flexibility to changing tasks and assignments.",Skills="Qualifications\r\n\r\nBachelor’s degree in Computer Engineering, Electrical and Electronics Engineering or any related discipline\r\nAt least 2 years of experience in software development\r\nHands-on project experience and proven knowledge in Microsoft .NET Framework / .NET Core\r\nStrong knowledge and hands-on experience in with ASP.NET, Restful API and C#\r\nKnowledge/experience in  Rabbitmq,websocket is a plus\r\nExperience with databases(SQL), database modelling and database access technologies is required\r\nExperience with Docker is required\r\nKnowledge in Restful web services is required\r\nKnowledge/experience in  .Net Core WebApi is a plus\r\nKnowledge/experience in  Angular is a plus\r\nStrong knowledge in Object Oriented Programming, Analyze and Design\r\nGood knowledge of web technologies; HTML5, CSS3, JavaScript\r\nStrong debugging skills and the proven ability to quickly understand other developers' code\r\nDemonstrated ability to meet tight deadlines, follow development standards and to work independently\r\nA good command of written and spoken English\r\nMale candidates should have no military obligations or postponed for at least two years\r\n \r\n\r\nArvento offers wide range of technology and turnkey solutions in vehicle, person, asset, container, boat tracking systems, fleet telematics and M2M solutions to more than 120.000 clients with more than 1.500.000 mobile devices.\r\n ", CompanyId=10 },
                new Job{Id=11,Title="Web Uzmanı (Dönemsel)",TypeOfWork=2,YearsOfExperience=5,WorkPlace=1,StartDate=DateTime.Parse("2024-11-28") ,Content="İlan Özeti\r\n28.11.2024 tarihinde İstanbul Okan Üniversitesi tarafından yayınlanan Web Uzmanı (Dönemsel) iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan İstanbul(Asya) / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyimsiz / Deneyimli arasında değişmektedir. Pozisyon Dönemsel (Sözleşmeli) ve çalışma konumu İş Yerinde olarak belirlenmiştir. İstanbul Okan Üniversitesi bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\ncms\r\nhtml\r\ncss\r\nBu becerilere sahip olmanız başvurunuzun dikkate alınma şansını artıracaktır.", Description="İlan Açıklaması\r\nÜniversitemizin Tuzla Kampüsü'nde yer alan Bilgi İşlem Müdürlüğü'nde görevlendirilmek üzere; \r\n\r\nCMS kullanma görev tecrübesi olan,\r\nWeb sayfalarının işleyişi konusunda bilgili,\r\nHTML ve CSS bilgisi ve tecrübesi olan,\r\nEn az mesleki ingilizce bilgisine sahip,\r\nAnalitik düşünme yapısına sahip,\r\nTakım çalışmasına yatkın,\r\nMS Office programlarına hakim,",Skills="\"Dönemsel Web Uzmanı\" arıyoruz.\r\n\r\nBeceriler\r\ncms\r\nhtml\r\ncss", CompanyId=11},
                new Job{Id=12,Title="Yazılım Uzmanı",TypeOfWork=3,YearsOfExperience=3,WorkPlace=3,StartDate=DateTime.Parse("2024-12-13") ,Content="İlan Özeti\r\n15.11.2024 tarihinde Qtech Bilgi Teknolojileri A.Ş. tarafından yayınlanan Yazılım Uzmanı iş ilanına başvurmadan önce pozisyonla ilgili önemli detayların kontrol edilmesi gerekir. Bu ilan İzmir / Türkiye konumu için açılmıştır. İlgili pozisyon için gereken deneyim süresi Deneyim: 4-6 Yıl arasında değişmektedir. Pozisyon Tam Zamanlı ve çalışma konumu Uzaktan olarak belirlenmiştir. Qtech Bilgi Teknolojileri A.Ş. bu pozisyon için başvuran adaylardan aşağıdaki becerilere sahip olmalarını beklemektedir:\r\n.net\r\nnosql\r\nreact", Description="İlan Açıklaması\r\nQ Yatırım Holding grup firmaları arasında Teknoloji şirketimiz olarak yer alan QTech, bilgi teknolojileri alanında ürün ve hizmetler sunmak, müşterilerinin dijital dönüşüm yolculuklarında güvenilir bir iş ortağı olmak amacıyla kurulmuştur. Memnuniyet odaklı hizmet anlayışıyla müşteri beklentilerini en üst seviyede karşılamayı amaçlayan QTech, alanında uzman kadrosu ve etkin bir müşteri deneyimi yönetimiyle en çok tercih edilen teknoloji şirketi olmayı hedeflemektedir.\r\n\r\nBu gelecek vizyon ile aşağıdaki niteliklere sahip şirketimizde görevlendirilmek üzereuzaktan çalışacak “Yazılım Uzmanı\" pozisyonu için arayışımız bulunmaktadır.",Skills="Genel Nitelikler\r\n\r\nÜniversitelerin Bilgisayar Mühendisliği veya ilgili alanlarda lisans derecesi, tercihen yüksek lisansı olan,\r\nDaha önce teknoloji firmalarında çalışma deneyimine sahip,\r\nKod dökümantasyonu ve teknik dokümantasyon oluşturma becerisine sahip,\r\nİyi derecede İngilizce bilgisine hakim,\r\n.NET Core tabanlı projelerde çalışacak,\r\nEn az 5 yıllık .NET Core ve .NET MVC deneyimi olan,\r\n \r\nİş Tanımı\r\n\r\nWeb uygulamalarının geliştirilmesi ve bakımını yapacak,\r\nVeritabanı yönetimi konusunda deneyimli,\r\nÖn yüz teknolojilerine hakim olan,\r\nSQL ve NoSql veritabanları yönetimi ve performans optimizasyonu konusunda ileri düzeyde bilgisi olan,\r\nReact veya Angular ile kapsamlı proje deneyimine sahip olan,\r\nMicroservices ve RESTful API geliştirme konusunda uzmanlık sahibi,\r\nDevOps araçları ve süreçleri hakkında bilgi sahibi,\r\nVersiyon kontrol sistemleri (Git, SVN vb.) konusunda deneyimli,\r\nBulut platformları (AWS, Azure) üzerinde çalışma deneyimi,\r\nCI/CD süreçleri konusunda bilgi sahibi olan,\r\nYazılım güvenliği ve performans iyileştirme tekniklerine hakim olan,\r\nAgile/Scrum metodolojileriyle çalışmış olan,\r\nClean code prensipleri konusunda bilgi sahibi olmak ve bu prensipleri uygulama deneyimi olan,\r\nYazılım testi ve birim testleri konusunda deneyim sahibi olan,\r\nTasarım desenleri (design patterns) ve yazılım mimarisi konularında deneyimine sahip.\r\nBeceriler\r\n.net\r\nnosql\r\nreact", CompanyId=12 },

            };
        }

    }
}
