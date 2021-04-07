using System;
using System.Collections.Generic;
using System.Text;

namespace Io.JoeMoceri.VideoEditor
{
    public interface IAppRepository
    {
        IEnumerable<BassEntry> GetBassEntries();
    }
    public class AppRepository : IAppRepository
    {
        public IEnumerable<BassEntry> GetBassEntries()
        {
            return new List<BassEntry>
            {
                //CreateBassEntry("Rush - Afterimage", "https://www.youtube.com/watch?v=aalJT3GS_m8", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html")
                //CreateBassEntry("Punch-Bowl", "https://www.youtube.com/watch?v=dkxrXWokYqQ", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html")
                //CreateBassEntry("Sin-Is-Jecht", "https://www.youtube.com/watch?v=VqCAhsWVH_g", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html"),
                //CreateBassEntry("Before-Yunalesca-Fight", "https://www.youtube.com/watch?v=0YSf43SH17k", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html"),
                //CreateBassEntry("jelly-jamboree", "https://www.youtube.com/watch?v=9GVzDMr1YJA", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html"),
                //CreateBassEntry("counterparts-solace", "https://www.youtube.com/watch?v=bMz7qOWxWm4", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html"),
                //CreateBassEntry("teach-me", "https://www.youtube.com/watch?v=hLbozjgBIE0", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html"),
                //CreateBassEntry("droid-the-ressurection", "https://www.youtube.com/watch?v=EB1UQcnApJY", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html"),
                //CreateBassEntry("slayer-raining-blood", "https://www.youtube.com/watch?v=hFjoOOPU6Xo", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html"),
                CreateBassEntry("static-x-love-dump", "https://www.youtube.com/watch?v=izWx8XB2CRg", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html"),
            };
            //return new List<BassEntry>
            //{
            //    CreateBassEntry("ACDC - Hard as a Rock", "https://www.youtube.com/watch?v=lplvDCAueZA", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hard_as_a_rock.html"),
            //    CreateBassEntry("ACDC - Live Wire", "https://www.youtube.com/watch?v=1gtLgAYCf5Y", "https://tabs.ultimate-guitar.com/tab/acdc/live-wire-bass-183314"),
            //    CreateBassEntry("ACDC - Who Made Who", "https://www.youtube.com/watch?v=wEupw9Ejmq8", "https://www.bigbasstabs.com/ac_dc_bass_tabs/who_made_who_ver_4.html"),
            //    CreateBassEntry("ACDC - Chase the Ace", "https://www.youtube.com/watch?v=oYw-ZTLqIpg", "https://tabs.ultimate-guitar.com/tab/acdc/chase-the-ace-bass-809842"),
            //    CreateBassEntry("ACDC - Shot Down in Flames", "https://www.youtube.com/watch?v=q6g_ggnZwx0", "https://www.bigbasstabs.com/ac_dc_bass_tabs/shot_down_in_flames.html"),
            //    CreateBassEntry("ACDC - Girls Got Rhythm", "https://www.youtube.com/watch?v=59lSt6fVgMA", "https://www.bigbasstabs.com/ac_dc_bass_tabs/girls_got_rhythm_ver_2.html"),
            //    CreateBassEntry("ACDC - If you want blood", "https://www.youtube.com/watch?v=aFCPrHmLo2c", "https://www.bigbasstabs.com/ac_dc_bass_tabs/if_you_want_blood.html"),
            //    CreateBassEntry("ACDC - Hell aint a bad place to be", "https://www.youtube.com/watch?v=qNfpkK5Uzqg", "https://tabs.ultimate-guitar.com/tab/acdc/hell-aint-a-bad-place-to-be-bass-631384"),
            //    CreateBassEntry("ACDC - Riff Raff", "https://www.youtube.com/watch?v=7S69xWkV4uM", "https://tabs.ultimate-guitar.com/tab/acdc/riff-raff-bass-1695240"),
            //    CreateBassEntry("ACDC - Hells Bells", "https://www.youtube.com/watch?v=GL56LY6fE0E", "https://www.bigbasstabs.com/ac_dc_bass_tabs/hells_bells_bass_tab.html"),
            //    CreateBassEntry("ACDC - Dirty Deeds Done Dirt Cheap", "https://www.youtube.com/watch?v=UIE4UjBtx-o", "https://www.bigbasstabs.com/ac_dc_bass_tabs/dirty_deeds_done_dirt_cheap.html"),
            //    CreateBassEntry("ACDC - Let there be rock", "https://www.youtube.com/watch?v=OvJrJcVAQQs", "https://www.bigbasstabs.com/ac_dc_bass_tabs/let_there_be_rock.html"),
            //    CreateBassEntry("ACDC - Thunderstruck", "https://www.youtube.com/watch?v=lhg9bYNLvOg", "https://www.bigbasstabs.com/ac_dc_bass_tabs/thunderstruck.html"),
            //    CreateBassEntry("ACDC - Shoot to Thrill", "https://www.youtube.com/watch?v=XGC4c9IiTTE", "https://www.bigbasstabs.com/ac_dc_bass_tabs/shoot_to_thrill.html"),
            //    CreateBassEntry("ACDC - Problem Child", "https://www.youtube.com/watch?v=EOpafs_mwpo", "https://tabs.ultimate-guitar.com/tab/acdc/problem-child-bass-971919"),
            //    CreateBassEntry("ACDC - Kicked in the Teeth", "https://www.youtube.com/watch?v=Oi1OfJLiDP8", "https://www.songsterr.com/a/wsa/ac-dc-kicked-in-the-teeth-bass-tab-s68754t2"),
            //    CreateBassEntry("Peter Tosh - Wanted Dread and Alive", "https://www.youtube.com/watch?v=h87cbH7Iogc", "https://tabs.ultimate-guitar.com/tab/peter-tosh/wanted-dread-and-alive-bass-836669"),
            //    CreateBassEntry("Peter Tosh - Reggaemylitis", "https://www.youtube.com/watch?v=q0j1mfJeNLE", "https://tabs.ultimate-guitar.com/tab/peter-tosh/reggaemylitis-bass-530610"),
            //    CreateBassEntry("Empire of the Sun - Old Flavours", "https://www.youtube.com/watch?v=uHkyFdsYw7M", "https://tabs.ultimate-guitar.com/tab/empire-of-the-sun/old-flavours-bass-1496423"),
            //    CreateBassEntry("Empire of the Sun - Way to Go", "https://www.youtube.com/watch?v=xg9ebVTL9yE", "https://tabs.ultimate-guitar.com/tab/empire-of-the-sun/way-to-go-bass-2808776"),
            //    CreateBassEntry("Rush - Bravado", "https://www.youtube.com/watch?v=pUSpBAmSMb8", "https://www.bigbasstabs.com/rush_bass_tabs/bravado.html"),
            //    CreateBassEntry("Rush - Time Stand Still", "https://www.youtube.com/watch?v=dMSFqXGZ5TQ", "https://www.bigbasstabs.com/rush_bass_tabs/time_stand_still_ver_2.html"),
            //    CreateBassEntry("Rob Zombie - Feel so Numb", "https://www.youtube.com/watch?v=1Q7bfj9_Jk8", "https://www.bigbasstabs.com/rob_zombie_bass_tabs/feel_so_numb_bass_tab.html"),
            //    CreateBassEntry("Rob Zombie - Superbeast", "https://www.youtube.com/watch?v=QC0BBgOdspo", "https://www.bigbasstabs.com/rob_zombie_bass_tabs/superbeast.html"),
            //    CreateBassEntry("Earthbound - Buy somethin' will ya", "https://www.youtube.com/watch?v=KcSzSpWdpwE", "https://www.gametabs.net/earthbound/buy-somethin-will-ya"),
            //    CreateBassEntry("Earthbound - Fourside", "https://www.youtube.com/watch?v=wlY84u8fkAg", "https://www.gametabs.net/earthbound/fourside-0"),
            //    CreateBassEntry("Earthbound - Franky", "https://www.youtube.com/watch?v=c3sdoKO-cLU", "https://www.gametabs.net/earthbound/franky"),
            //    CreateBassEntry("Earthbound - Hospital", "https://www.youtube.com/watch?v=61XBpz5WiTQ", "https://www.gametabs.net/earthbound/hospital"),
            //    CreateBassEntry("Earthbound - Onett", "https://www.youtube.com/watch?v=7y5RRgjfNek", "https://www.gametabs.net/super-nintendo/earthbound/onett-bass"),
            //    CreateBassEntry("Earthbound - Opening Credits", "https://www.youtube.com/watch?v=-jjFUgKiaiw", "https://www.gametabs.net/super-nintendo/earthbound/opening-credits-bass"),
            //    CreateBassEntry("Earthbound - Pokey means business", "https://www.youtube.com/watch?v=QLR4mnndnj0", "https://www.gametabs.net/earthbound/pokey-means-business"),
            //    CreateBassEntry("Earthbound - The unforgiving desert", "https://www.youtube.com/watch?v=NDiwFW0fwYM", "https://www.gametabs.net/earthbound/unforgiving-desert"),
            //    CreateBassEntry("Earthbound - Hi Hi Hi", "https://www.youtube.com/watch?v=8jdkvKswphU", "https://www.gametabs.net/super-nintendo/earthbound/welcome-to-saturn-valley-bass"),
            //    CreateBassEntry("Earthbound - You're name, please", "https://www.youtube.com/watch?v=OuRBHEa6ZjA", "https://www.gametabs.net/earthbound/your-name-please"),
            //    CreateBassEntry("Chrono Trigger - Corridors of Time", "https://www.youtube.com/watch?v=bNzYIEY-CcM", "https://www.gametabs.net/chrono-trigger/corridors-time"),
            //    CreateBassEntry("Chrono Trigger - Courage and Pride", "https://www.youtube.com/watch?v=IgPtGSdLliQ", "https://www.gametabs.net/super-nintendo/chrono-trigger/courage-and-pride"),
            //    CreateBassEntry("Chrono Trigger - Frogs Theme", "https://www.youtube.com/watch?v=WYRFMUNIUVw", "https://www.gametabs.net/super-nintendo/chrono-trigger/frogs-theme"),
            //    CreateBassEntry("Chrono Trigger - Wind Scene", "https://www.youtube.com/watch?v=hELte7HgL2Y", "https://www.gametabs.net/super-nintendo/chrono-trigger/wind-scene"),
            //    CreateBassEntry("Chrono Trigger - A Strange Happening", "https://www.youtube.com/watch?v=eNrqch6aDwc", "https://www.gametabs.net/super-nintendo/chrono-trigger/a-strange-happening"),
            //    CreateBassEntry("Chrono Trigger - Secret of the Forest", "https://www.youtube.com/watch?v=2r1iesThvYg", "https://www.gametabs.net/chrono-trigger/secret-of-forest"),
            //    CreateBassEntry("Chrono Trigger - Lavos", "https://www.youtube.com/watch?v=-X1-uqDYa7w", "https://www.gametabs.net/super-nintendo/chrono-trigger/lavos"),
            //    CreateBassEntry("Chrono Trigger - Silent Light", "https://www.youtube.com/watch?v=bW3KNnZ2ZiA", "https://www.gametabs.net/super-nintendo/chrono-trigger/silent-light"),
            //    CreateBassEntry("Chrono Trigger - Black Omen", "https://www.youtube.com/watch?v=Bb4YB0ia46w", "https://www.gametabs.net/super-nintendo/chrono-trigger/black-omen-bass"),
            //    CreateBassEntry("Chrono Trigger - Battle with Magus", "https://www.youtube.com/watch?v=JKRRXt8J5YU", "https://www.gametabs.net/super-nintendo/chrono-trigger/magus-battle-theme-bass"),
            //    CreateBassEntry("Super Mario RPG - Fight against an armed boss", "https://www.youtube.com/watch?v=8WjMytgvcus", "https://www.gametabs.net/super-mario-rpg/fight-against-armed-boss"),
            //    CreateBassEntry("Donkey Kong Country - Bonus Stage", "https://www.youtube.com/watch?v=RSnvMnj7xYg", "https://www.gametabs.net/donkey-kong-country/bonus-stage"),
            //    CreateBassEntry("Donkey Kong Country - Gang-plank Galleon", "https://www.youtube.com/watch?v=lS7_tcwsj4E", "https://www.gametabs.net/super-nintendo/donkey-kong-country/gangplank-galleon-bass"),
            //    CreateBassEntry("Donkey Kong Country - Jungle Hijinx", "https://www.youtube.com/watch?v=jjRw9X2Hxro", "https://www.gametabs.net/super-nintendo/donkey-kong-country/jungle-hijinx-bass"),
            //    CreateBassEntry("Donkey Kong Country - Main Theme", "https://www.youtube.com/watch?v=nLT1-5laF0A", "https://www.gametabs.net/super-nintendo/donkey-kong-country/main-theme"),
            //    CreateBassEntry("Donkey Kong Country 2 - Snakey Chantey", "https://www.youtube.com/watch?v=Mr2cFY_3PT0", "https://www.gametabs.net/donkey-kong-country-2/snakey-chantey"),
            //    CreateBassEntry("Donkey Kong Country 2 - Roller Coaster (Disco Train)", "https://www.youtube.com/watch?v=yUGU_Zlf9tU", "https://www.gametabs.net/donkey-kong-country-2/roller-coaster"),
            //    CreateBassEntry("Link to the Past - Dark World", "https://www.youtube.com/watch?v=BStjuHfP238", "https://www.gametabs.net/legend-zelda-link-to-past/dark-world-0"),
            //    CreateBassEntry("Link to the Past - Opening Demo", "https://www.youtube.com/watch?v=QEXe-W9HxUw", "https://www.gametabs.net/legend-of-zelda-a-link-to-past/opening-demo-0"),
            //    CreateBassEntry("Link to the Past - Falling Rain", "https://www.youtube.com/watch?v=9413Wiw-KuY", "https://www.gametabs.net/legend-of-zelda-a-link-to-past/time-of-falling-rain-0"),
            //    //CreateBassEntry("Link to the Past - Title theme", "videoUrl", "bassTabUrl"),
            //    CreateBassEntry("Wind Waker - Outset Island", "https://www.youtube.com/watch?v=hUiAmrtxits", "https://www.gametabs.net/legend-zelda-wind-waker/outset-island-0"),
            //    CreateBassEntry("Super Mario World - Castle Theme", "https://www.youtube.com/watch?v=fdmS4ndSAT8", "https://www.gametabs.net/super-nintendo/super-mario-world/castle"),
            //    CreateBassEntry("Super Mario World - Ending Theme", "https://www.youtube.com/watch?v=waKumDkYrDY", "https://www.gametabs.net/super-mario-world/ending-theme"),
            //    CreateBassEntry("Super Mario World - Fortress Boss (Koopa Kid Boss Fight)", "https://www.youtube.com/watch?v=ipbeQSSdfrk", "https://www.gametabs.net/super-mario-world/koopa-kid-boss-fight"),
            //    CreateBassEntry("Super Mario World - Overworld Theme", "https://www.youtube.com/watch?v=tAaGKo4XVvM", "https://www.gametabs.net/super-nintendo/super-mario-world/level-1"),
            //    CreateBassEntry("Super Mario World - Underground Theme", "https://www.youtube.com/watch?v=M7G--2s3bdc", "https://www.gametabs.net/super-mario-world/underworld"),
            //    CreateBassEntry("Super Mario World - World Map Theme", "https://www.youtube.com/watch?v=tOHWckGtcHs", "https://www.gametabs.net/super-mario-world/world-map-theme"),
            //    CreateBassEntry("Mega Man X - Boomer Kuwanger", "https://www.youtube.com/watch?v=3kOjXM0sH84", "https://www.gametabs.net/mega-man-x/boomer-kuwanger"),
            //    CreateBassEntry("Mega Man X - Chill Penguin", "https://www.youtube.com/watch?v=EwfKSRUQuZM", "https://www.gametabs.net/super-nintendo/mega-man-x/chill-penguin-stage"),
            //    CreateBassEntry("Mega Man X - Launch Octopus", "https://www.youtube.com/watch?v=sUm4WhFixLs", "https://www.gametabs.net/mega-man-x/launch-octopus"),
            //    CreateBassEntry("Mega Man X - Sigma Stage 1", "https://www.youtube.com/watch?v=Ju5qPxgFoQs", "https://www.gametabs.net/mega-man-x/sigma-stage-one"),
            //    CreateBassEntry("DOOM - Intermission from DOOM", "https://www.youtube.com/watch?v=UuITgxaSk1c", "https://www.gametabs.net/pc/doom/intermission"),
            //    CreateBassEntry("DOOM 2 - Entryway (Running from Evil)", "https://www.youtube.com/watch?v=JPHPJ3CgidU", "https://www.gametabs.net/pc/doom-2/entryway-bass"),
            //    CreateBassEntry("DOOM 2 - The Healer Stalks", "https://www.youtube.com/watch?v=44lhqrsUTlo", "https://www.gametabs.net/pc/doom-2/healer-stalks"),
            //    CreateBassEntry("DOOM 2 - Waiting for Romero to Play", "https://www.youtube.com/watch?v=TnzRBZd5_uA", "https://www.gametabs.net/pc/doom-2/waiting-for-romero-to-play"),
            //    CreateBassEntry("Pokemon Red - Route 1 theme", "https://www.youtube.com/watch?v=u0G12EBW4KY", "https://www.gametabs.net/pokemon-red-blue-yellow/route-1-0"),
            //    CreateBassEntry("Bob Marley - Buffalo Soldier", "https://www.youtube.com/watch?v=S5FCdx7Dn0o", "https://www.bigbasstabs.com/bob_marley_bass_tabs/buffalo_soldier.html"),
            //    CreateBassEntry("Bob Marley - Natural Mystic", "https://www.youtube.com/watch?v=Z0lufcRgZlA", "https://tabs.ultimate-guitar.com/tab/bob-marley/natural-mystic-bass-797396"),
            //    CreateBassEntry("Bob Marley - Who the cap fit", "https://www.youtube.com/watch?v=wE4TpnYIsW4", "https://www.bigbasstabs.com/bob_marley_bass_tabs/who_the_cap_fit.html"),
            //    CreateBassEntry("Bob Marley - Stir it up", "https://www.youtube.com/watch?v=S3UqvWk8-uw", "https://www.bigbasstabs.com/bob_marley_bass_tabs/stir_it_up_ver_2.html"),
            //    CreateBassEntry("Bob Marley - Jah Live", "https://www.youtube.com/watch?v=a8oRqXKYXvs", "https://www.bigbasstabs.com/bob_marley_bass_tabs/jah_live.html"),
            //};
        }

        private BassEntry CreateBassEntry(string name, string videoUrl, string bassTabUrl)
        {
            return new BassEntry
            {
                Name = name,
                VideoUrl = videoUrl,
                BassTabUrl = bassTabUrl
            };
        }
    }
}
