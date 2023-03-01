using Demo1._1.concrete;
using Demo1._1.entities;

Gamer gamer= new Gamer();
gamer.id = 1;
gamer.GamerFirstName = "Tufan";
gamer.GamerLastName = "Karaçam";
gamer.DateOfBirth= DateTime.Now;
gamer.NationlityId = "99999999999";

Game game= new Game();
game.Id= 1;
game.GameDescription = "Aksiyon";
game.GamePrice = 145;
game.GameName = "Hitman";

Campaign campaign= new Campaign();
campaign.Id= 1;
campaign.CampaignName = "karne günü";
campaign.CampaignDescription = "çocuklar için";

GamerManager gamerManager= new GamerManager();
gamerManager.SignIn(gamer);

CampaignManager campaignManager= new CampaignManager();
campaignManager.CampaignAdd(campaign);

SalesManager salesManager= new SalesManager();
salesManager.SalesWithCampaign(game, gamer, campaign);




