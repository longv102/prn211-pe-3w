USE master
GO

CREATE DATABASE ArtTattoo2023DB
GO

USE ArtTattoo2023DB
GO

CREATE TABLE AccountMember(
  AccountID int primary key,
  Password nvarchar(40) not null,
  FullName nvarchar(60) not null,
  EmailAddress nvarchar(60) unique, 
  Role int
)
GO

INSERT INTO AccountMember VALUES(12 ,N'@1', N'Administrator', 'admin@ArtTattooService.com.uk', 1);
INSERT INTO AccountMember VALUES(13 ,N'@1', N'Staff', 'staff@ArtTattooService.com.uk', 2);
INSERT INTO AccountMember VALUES(14 ,N'@1', N'Manager', 'manager@ArtTattooService.com.uk', 3);
INSERT INTO AccountMember VALUES(15 ,N'@1', N'Customer', 'customer@ArtTattooService.com.uk', 4);
GO


CREATE TABLE ArtTattooService(
  ServiceId nvarchar(30) primary key,
  ServiceName nvarchar(90) not null,
  ServiceNote nvarchar(250) not null, 
  ServiceAddress nvarchar(120), 
  TelephoneNumber nvarchar(15)
)
GO
INSERT INTO ArtTattooService VALUES(N'TS0005',N'Aman Inkplay Tattoo Studio',N'Offer Home Services, Outdoor Services', N'Shop No-11, House No-R-1, Uttam Nagar West, Delhi - 110059 (Near Uttam Nagar West Metro Station(690) Gate 1)', N'08123863354')
GO
INSERT INTO ArtTattooService VALUES(N'TS0006',N'Amazing Tattoo Studio',N'Offer Home Services, Price Category-Economic', N'Shop Number 212, Second Floor, Atta Market, Noida - 201301 (Near Bikanerwala Sector 18, Opposite Metro)', N'08123070787')
GO
INSERT INTO ArtTattooService VALUES(N'TS0007',N'Empire Ink Tattoo Studio & Training Institute',N'Timeline: Mon - Sun 11:00 am - 9:00 pm', N'Shop No G-29, Raj Nagar Extension Ghaziabad, Ghaziabad - 201017 (Near Vvip Mall)', N'08123906011')
GO
INSERT INTO ArtTattooService VALUES(N'TS0008',N'Colours Tattoo Body Piercing',N'Year of Establishment: 2010', N'Shop 119 Palika Bajar, Palika Bazar, Delhi - 110001 (Gate No.3)', N'08105839586')
GO
INSERT INTO ArtTattooService VALUES(N'TS0009',N'New Look Tattoo Gallery',N'Mon - Sun, 10:00 am - 9:00 pm', N'House NO- A-4/24, Main Road, Rohini Sector 4, Delhi - 110085 (Opp. Mother DivinePublic School)', N'09035240239')
GO

CREATE TABLE ArtTattooStyle(
 TattooStyleId int primary key,
 TattooStyleName nvarchar(120) not null,
 StyleDescription nvarchar(200),
 StylePrice float,
 TattooLocation nvarchar(80), 
 ServiceId nvarchar(30) references ArtTattooService(ServiceId) on delete cascade on update cascade
)
GO

INSERT INTO ArtTattooStyle VALUES(101, N'Traditional', N'This style is characterized by bold outlines, vivid colors, and iconic imagery, often inspired by Americana and folk art.', 118, N'Arms, Back, Chest', 'TS0005')
GO
INSERT INTO ArtTattooStyle VALUES(102, N'Realism', N'Realism focuses on creating tattoos that closely resemble realistic portraits or objects. Artists in this style pay attention to detail, shading, and use techniques that mimic the look of photographs.', 432, N'Legs, Wrists and Hands, Neck', 'TS0006')
GO
INSERT INTO ArtTattooStyle VALUES(103, N'Watercolor', N'Watercolor tattoos resemble free-flowing watercolor paintings. They typically lack black outlines and incorporate vibrant colors that blend and bleed into one another.', 267, N'Feet and Ankles', 'TS0007')
GO
INSERT INTO ArtTattooStyle VALUES(104, N'Minimalism', N'Minimalist tattoos are characterized by simple and clean designs with minimal detail. They often feature single line work, geometric shapes, and abstract designs.', 221, N'Arms, Feet and Ankles', 'TS0005')
GO
INSERT INTO ArtTattooStyle VALUES(105, N'Neo-traditional', N'Neo-traditional tattoos combine elements of the traditional style with more modern techniques and design elements. They often feature bold colors, heavy shading, and intricate details.', 231, N'Wrists and Hands, Neck', 'TS0005')
GO
INSERT INTO ArtTattooStyle VALUES(106, N'Japanese', N'Japanese-style tattoos, also known as Irezumi, feature large and colorful designs with traditional Japanese motifs such as koi fish, dragons, cherry blossoms, and samurai.', 243, N'Legs, Wrists and Hands, Neck, Arms', 'TS0008')
GO
INSERT INTO ArtTattooStyle VALUES(107, N'Tribal', N'Tribal tattoos draw inspiration from ancient indigenous cultures and incorporate bold, black patterns and symbols. These tattoos are often associated with specific tribes or spiritual beliefs.', 412, N'Wrists and Hands, Feet and Ankles, Arms', 'TS0008')
GO
INSERT INTO ArtTattooStyle VALUES(108, N'Japanese or Irezumi', N'Originating from Japanese culture, these tattoos feature large, detailed designs with vibrant colors. Traditional Japanese tattoos often depict mythological creatures, nature elements.', 128, N'Feet and Ankles, Arms, Chest, Back', 'TS0009')
GO