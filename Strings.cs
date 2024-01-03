using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x02000003 RID: 3
internal static class Strings
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
	public static string Get(STRING key)
	{
		string result;
		if (Strings._dict.ContainsKey(CultureInfo.CurrentCulture.Name) && Strings._dict[CultureInfo.CurrentCulture.Name].TryGetValue(key, out result))
		{
			return result;
		}
		if (Strings._dict.ContainsKey(CultureInfo.CurrentCulture.Parent.Name) && Strings._dict[CultureInfo.CurrentCulture.Parent.Name].TryGetValue(key, out result))
		{
			return result;
		}
		if (Strings._dict["en"].TryGetValue(key, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0400007F RID: 127
	private static Dictionary<STRING, string> _dict_cs_CZ = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"ZKUSIT ZNOVU"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"POKRAČOVAT"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"ZRUŠIT"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"ZADNÍ"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"REINSTALOVAT"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"SPUSTIT"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"ODINSTALOVAT"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"ZAHÁJIT VEČÍREK"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"UKONČIT"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"RESTARTOVAT NYNÍ"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"RESTARTOVAT POZDĚJI"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"NÁPOVĚDA ONLINE"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"Na disku {0} je momentálně k\u00a0dispozici {1} GB"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Na disku {0} je k\u00a0dispozici méně než 1 GB"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Na disku {0} je k\u00a0dispozici méně než 500\u00a0MB"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Inicializace stahování se nezdařila z\u00a0důvodu problému se sítí. Zkuste to znovu."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Stahování se nezdařilo z\u00a0důvodu problému se sítí. Zkuste to znovu."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Nelze získat platný souhrn aktualizace. Zkuste to znovu."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Nedostatek volného místa na disku."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Během instalace došlo k\u00a0chybě. Zkuste to znovu."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Nepodařilo se rozbalit zdroje instalačního programu. Zkuste tento problém vyřešit restartováním instalačního programu."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Základní součásti instalačního programu nelze načíst."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Nepodařilo se spustit instalaci. Zkuste tento problém vyřešit ukončením instalačního programu a jeho restartováním."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Stáhněte si jej znovu z "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB není kompatibilní s\u00a0vaším aktuálním operačním systémem. Chcete-li se dozvědět více, zkontrolujte kompatibilitu G HUB s\u00a0operačními systémy."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"OFICIÁLNÍCH STRÁNEK."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERZE {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Instalace do {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB z {1} MB ({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Zaznamenali jsme pomalou rychlost stahování"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Může to počkat? Právě probíhají určité kalibrace"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Zajišťujeme, aby vaše tiskárna a historie soukromého procházení byly správně připojeny"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Odvádění výkonu reaktoru"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Vyvolávání kočky Nyan"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Je zapotřebí více plynu vespene"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Nedělám nic podezřelého. Opravdu!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Teselace matice nekonečna"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Musíte postavit další pylony"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"Vitamin D je nezbytný pro lidské tělo"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Pohon Frame Shift Drive, zapnutý"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Lepší myš v\u00a0hrsti než krysa v\u00a0díře"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Čas letí, když se bavíte"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Zkusíme z\u00a0vašeho systému něco vymáčknout"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Tohle také projde"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Oblékaní kalhot"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Posíláme našeho nejlepšího bojovníka"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Modrozelená vypadá divně..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Reticulating splines"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Spřádání plánu na ovládnutí světa"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Co dělá tohle tlačítko?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hej, ty. Konečně jsi vzhůru"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"K dokončení instalace náležitostí je nutné restartovat počítač. Po restartování počítače se instalační program znovu spustí."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Instalace se nezdařila."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Inicializace se nezdařila."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Již nainstalováno."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Přeinstalovat G HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Probíhá odinstalace."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Odinstalace proběhla úspěšně."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Chyba odinstalace."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Ukončit instalaci."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Je vyžadován restart."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Opravdu chcete skončit?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Inicializace"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Rozbalování"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Probíhá instalace"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Dokončování"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Kliknutím na „Instalovat“ souhlasíte s\u00a0podmínkami "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"LICENČNÍ SMLOUVY S\u00a0KONCOVÝM UŽIVATELEM."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Čekejte prosím, probíhá instalace G HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB je nainstalován a podle všeho funguje správně."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Spusťte G HUB a vyhledejte aktualizace"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Přeinstalovat G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Tento software je již v\u00a0systému nainstalován, ale vypadá poškozený. Reinstalace by jej mohla opravit."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Reinstalace nejprve odinstaluje stávající software G HUB. Tuto operaci nelze zrušit ani vrátit zpět."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB byl úspěšně odinstalován ze systému."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Čekejte prosím, probíhá odinstalace G HUB. Tato operace může nějakou dobu trvat."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Předchozí instalace G HUB byla odstraněna. Můžete pokračovat v\u00a0nové instalaci."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Přenést moje aktuální nastavení"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Odinstalátor G HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Chybí důležité součásti: Přeinstalujte balíček Microsoft Visual C++ Redistributable 2019 nebo stáhněte a použijte instalační program G HUB ze stránky podpory."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Čekejte prosím, probíhá odinstalace G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Odebírání součástí softwaru"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Odstraňování zbývajících souborů"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Čištění"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Při odinstalaci G HUB došlo k\u00a0chybě: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Zkuste restartovat počítač a spusťte odinstalační program znovu."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Nepodařilo se odebrat klíče registru."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Některé složky se nepodařilo odstranit."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Některé soubory se nepodařilo odstranit."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Nepodařilo se odebrat službu G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Nepodařilo se zastavit procesy G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Neznámá chyba (kód {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Odinstalovat"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Odinstalováním dojde k\u00a0odebrání G HUB ze systému. Opravdu chcete pokračovat? Tuto operaci nelze vrátit zpět."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Instalační program Logitech G HUB"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Instalační aplikace Logitech G HUB"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALOVAT"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"UKONČIT"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Tento software již v\u00a0systému existuje. Spusťte G HUB a vyhledejte aktualizace."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"V systému se nachází zastaralá a nekompatibilní verze softwaru Logitech Gaming Software. Proveďte upgrade nebo ji odstraňte a nainstalujte software G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"STAHOVÁNÍ SOFTWARU LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Nový software Logitech G HUB zkvalitní používání konfigurací vašich her a zařízení…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…budování a ochrana…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…úkrokování a přidávání…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…vznášení a přistávání…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"STAHOVÁNÍ BYLO ÚSPĚŠNĚ DOKONČENO"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Nyní je vše připraveno."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALOVAT A SPUSTIT"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"O programu"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Konec"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Zavřít okno"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"zbývá"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Během instalace došlo k\u00a0chybě"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Stažení se nezdařilo:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Nezdařilo se získat platný souhrn aktualizace."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Stažení se nezdařilo: Inicializace se nezdařila. Zkontrolujte své internetové připojení a zkuste to znovu."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Zkontrolujte své internetové připojení."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Disk je zdá se plný."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Základní součásti instalačního programu nelze načíst. Stáhněte si instalační program znovu z\u00a0oficiálních stránek."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Opakování za %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Extrakce souborů"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000080 RID: 128
	private static Dictionary<STRING, string> _dict_da_DK = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"PRØV IGEN"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"FORTSÆT"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"ANNULLER"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"BAGSIDE"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"GENINSTALLER"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"START"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"AFINSTALLER"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"LAD OS HOLDE EN FEST"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"AFSLUT"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"GENSTART NU"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"GENSTART SENERE"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"ONLINEHJÆLP"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0}GB ledig på {1} drev"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Under 1 GB ledig på {0} drev"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Under 500 MB ledig på {0} drev"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Downloadinitialisering mislykkedes pga. netværksproblem. Prøv igen."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Download mislykkedes pga. netværksproblem. Prøv igen."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Kunne ikke hente gyldig opdateringsoversigt. Prøv igen."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Ikke nok ledig plads på harddisken."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Der opstod en fejl under installationen. Prøv igen."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Kunne ikke pakke installationsressourcer ud. Genstart af installationsprogrammet kan måske løse dette problem."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Installationsprogrammets nødvendige komponenter kunne ikke indlæses."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Kunne ikke starte installation. Lukning af installationsprogrammet og genstart af det kan måske løse dette problem."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Download det igen fra det "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB er ikke kompatibel med dit nuværende operativsystem. Kontroller G HUB OS-kompatibilitet for at lære mere."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"OFFICIELLE WEBSTED."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSION {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Installerer på {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB af {1} MB ({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Vi registrerer langsomme downloadhastigheder"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Kan det vente? Vi er lige ved at foretage nogle kalibreringer"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Kontrollerer, at din printer og din incognitohistorik er korrekt forbundet"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Omdirigerer reaktorkraft"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Tilkalder en Nyan-kat"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Du har brug for mere vespene-gas"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Jeg foretager mig ikke noget mistænkeligt. Jeg sværger!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Tessellerer infinity-matrixen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Du skal konstruere flere pyloner"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"D-vitamin er nødvendig for menneskekroppen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Rammeskift, til"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Hellere én mus i hånden end to i busken"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Tiden flyver, når man har det sjovt"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Få noget ud af dit system"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Dette vil også gå over"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Tager bukser på"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Sender vores bedste kriger"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan ser mistænkelig ud..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Forsyner sløjfer med net"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Udfører plan for verdensdominans"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Hvad gør denne knap?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hey, du. Du er endelig vågen"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Der kræves en genstart for at afslutte installationen. Installationsprogrammet åbnes igen, når computeren er genstartet."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Installationen mislykkedes."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Installationen mislykkedes."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Allerede installeret."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Geninstaller G HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Afinstallerer."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Afinstallationen lykkedes."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Fejl ved afinstallation."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Afbryd installation."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Genstart kræves."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Er du sikker på at du vil afbryde?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Initialiserer"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Pakker ud"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Installerer"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Afslutter"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Når du klikker på \"installer\", accepterer du vilkårene i "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"SLUTBRUGERLICENSAFTALEN."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Vent et øjeblik, mens G HUB installeres."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB er installeret og ser ud til at fungere korrekt."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Start G HUB for at tjekke, om der er opdateringer"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Geninstaller G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Denne software er allerede installeret på systemet, men ser ud til at være beskadiget. En geninstallation kan måske rette op på det."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Ved geninstallation afinstalleres først din eksisterende G HUB-software. Denne handling kan ikke annulleres eller gøres om."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB er blevet afinstalleret fra systemet."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Vent, mens vi afinstallerer G HUB. Denne handling kan tage lidt tid."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Den forrige installation af G HUB er blevet fjernet. Du kan fortsætte med en ny installation."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Overfør mine nuværende indstillinger"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Afinstallationsprogram til G HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Kritiske komponenter mangler: Afinstaller Microsoft Visual C++ Redistributable 2019 eller download og brug installationsprogrammet til G HUB fra supportwebstedet."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Vent, mens vi afinstallerer G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Fjerner softwarekomponenter"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Sletter tilbageværende filer"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Gør rent"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Der opstod en fejl ved afinstallation af G HUB: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Prøv at genstarte din computer, og gør afinstallationsprogrammet igen."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Kunne ikke fjerne registreringsdatabasenøgler."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Kunne ikke slette visse mapper."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Kunne ikke slette visse filer."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Kunne ikke fjerne G HUB-tjenesten."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Kunne ikke stoppe G HUB-processen."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Ukendt fejl (kode {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Afinstaller"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Afinstallation vil fjerne G HUB fra dit system. Er du sikker på at du vil fortsætte? Denne handling kan ikke gøres om."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech G HUB-installation"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech G HUB-installationsprogram"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALLER"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"AFSLUT"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Softwaren findes allerede på systemet. Start G HUB for at tjekke, om der er opdateringer."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"Der findes en gammel og inkompatibel version af Logitech Gaming Software på systemet. Opgrader eller fjern softwaren for at installere G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"DOWNLOADER LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Den nye Logitech G HUB-software vil forbedre dit spil og konfigurationen af din enhed …"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"… bygger og beskytter …"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"… beskydning og boosting…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"… svæver og lander …"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"DOWNLOAD GENNEMFØRT"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Låst og ladt."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALLER OG START"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Om"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Afslut"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Luk vinduet"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"tilbage"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Der opstod en fejl under installationen"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Kunne ikke downloade:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Kunne ikke hente en gyldig opdateringsoversigt."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Kunne ikke downloade: Installationen mislykkedes. Kontrollér internetforbindelsen, og prøv igen."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Kontrollér internetforbindelsen."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Disken ser ud til at være fuld."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Installationsprogrammets nødvendige komponenter kunne ikke indlæses. Download installationsprogrammet fra det officielle websted."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Prøver igen om %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Udpakning af filer"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000081 RID: 129
	private static Dictionary<STRING, string> _dict_de_DE = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH\u00a0G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"ERNEUT VERSUCHEN"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"WEITER"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"ABBRECHEN"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"RÜCKSEITE"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"NEU INSTALLIEREN"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"STARTEN"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"DEINSTALLIEREN"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"DIE PARTY GEHT LOS"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"BEENDEN"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"JETZT NEU STARTEN"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"SPÄTER NEU STARTEN"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"ONLINE-HILFE"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0} GB verfügbar auf Laufwerk {1}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Weniger als 1 GB verfügbar auf Laufwerk {0}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Weniger als 500 MB verfügbar auf Laufwerk {0}"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Download-Initialisierung fehlgeschlagen wegen Netzwerkproblem. Bitte versuche es erneut."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Download fehlgeschlagen wegen Netzwerkproblem. Bitte versuche es erneut."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Es konnte keine gültige Update-Zusammenfassung abgerufen werden. Bitte versuche es erneut."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Freier Festplattenspeicher nicht ausreichend."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Bei der Installation ist ein Fehler aufgetreten. Bitte versuche es erneut."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Extraktion der Installationsressourcen fehlgeschlagen. Das Problem kann möglicherweise durch das Neustarten des Installationsprogramms behoben werden."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Wesentliche Komponenten des Installationsprogramms konnten nicht geladen werden."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Starten der Installation fehlgeschlagen. Das Problem kann möglicherweise durch Schließen und Neustarten des Installationsprogramms behoben werden."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Bitte lade sie erneut herunter von der "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB ist mit deinem derzeitigen Betriebssystem nicht kompatibel. Mehr erfährst du in den OS-Kompatibilitätsinfos von G Hub."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"OFFIZIELLEN WEBSITE."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSION {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Installieren in {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB von {1} MB ({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Niedrige Downloadgeschwindigkeit wurde erkannt"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Später herunterladen? Wir führen gerade eine Kalibrierung durch"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Vergewissere dich, dass der Drucker und dein Inkognito-Verlauf ordnungsgemäß verbunden sind"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Umleiten der Reaktorenergie"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Aufrufen der Nyan Katze"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Du brauchst mehr Vespene-Gas"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Ich mache nichts Unanständiges. Ehrenwort!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Tesselieren der Infinity-Matrix"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Du musst mehr Masten bauen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"Der menschliche Körper braucht Vitamin D"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Rahmenschaltgetriebe, Aktiv"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Ein Spatz in der Hand ist besser als eine Taube am Dach"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Wie doch die Zeit verfliegt"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Du willst was loswerden"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Auch das wirst du überstehen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Putting on pants"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Besten Krieger senden"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan schaut verdächtig aus..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Netzverzahnungen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Plan für Weltherrschaft umsetzen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Was macht diese Taste?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hallo. Du bist ja endlich wach"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Um die Installation der Voraussetzungen abzuschließen, ist ein Neustart nötig. Das Installationsprogramm wird nach dem Neustart des Computers erneut geöffnet."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Installation fehlgeschlagen."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Installation fehlgeschlagen."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Bereits installiert."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"G HUB erneut installieren?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Deinstallation läuft."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Deinstallation erfolgreich."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Fehler bei Deinstallation."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Installation abbrechen."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Neustart erforderlich."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Soll wirklich abgebrochen werden?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Initialisierung"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Extraktion"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Installation läuft"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Abschluss"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Durch Klicken auf „Installieren“ erklärst du deine Zustimmung zu "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"ENDBENUTZER-LIZENZVERTRAG"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Bitte warten, während G HUB installiert wird."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB ist installiert und scheint ordnungsgemäß zu funktionieren."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"G HUB starten und nach Updates suchen"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"G HUB erneut installieren"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Diese Software ist auf diesem System bereits installiert, scheint aber beschädigt zu sein. Das Problem kann möglicherweise durch eine Neuinstallation behoben werden."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Bei der Neuinstallation wird zuerst die vorhandene G HUB Software entfernt. Dieser Vorgang kann weder abgebrochen noch rückgängig gemacht werden."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB wurde vom System entfernt."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Bitte warten, während G HUB deinstalliert wird. Dieser Vorgang kann einige Zeit in Anspruch nehmen."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Die vorherige Installation von G HUB wurde entfernt. Die Neuinstallation kann jetzt durchgeführt werden."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Aktuelle Einstellungen übertragen"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB Deinstallationsprogramm"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Kritische Komponenten fehlen: Bitte Microsoft Visual C++ Redistributable 2019 erneut installieren oder herunterladen und das G HUB Installationsprogramm von der Support-Website verwenden."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Bitte warten, während G HUB deinstalliert wird."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Softwarekomponenten entfernen"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Verbleibende Dateien löschen"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Aufräumen"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Bei der Deinstallation von G HUB ist ein Fehler aufgetreten: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Starte den Computer erneut und führe das Deinstallationsprogramm noch einmal aus."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Fehler beim Entfernen der Registrierungseinträge."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Fehler beim Löschen einiger Ordner."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Fehler beim Löschen einiger Dateien."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Fehler beim Löschen des G HUB Diensts."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Fehler beim Anhalten des G HUB Vorgangs."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Unbekannter Fehler (Code {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Deinstallieren"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Bei der Deinstallation wird G HUB von deinem System entfernt. Willst du wirklich fortfahren? Dieser Vorgang kann weder abgebrochen noch rückgängig gemacht werden."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech\u00a0G HUB Installationsprogramm"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech\u00a0G HUB Installationsanwendung"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALLIEREN"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"BEENDEN"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Diese Software ist bereits auf dem System vorhanden. G HUB starten und nach Updates suchen."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"Eine veraltete und inkompatible Version der Logitech Gaming Software ist auf dem System vorhanden. Diese Software muss zuerst aktualisiert oder entfernt werden zum Installieren von G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"DOWNLOAD VON LOGITECH\u00a0G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Die neue Logitech G\u00a0HUB Software verbessert das Benutzererlebnis bei der Spiele- und Geräte-Konfiguration\u00a0…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…\u00a0Aufbauen und Verteidigen\u00a0…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…\u00a0Ausweichen und Anvisieren\u00a0…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…\u00a0Schweben und Landen\u00a0…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"DOWNLOAD ERFOLGREICH"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Alles fertig zum Einsatz."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALLIEREN UND STARTEN"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Info"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Beenden"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Fenster schließen"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"verbleibend"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Während der Installation ist ein Fehler aufgetreten"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Download nicht möglich:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Es konnte keine gültige Update-Zusammenfassung abgerufen werden."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Download nicht möglich: Installation fehlgeschlagen. Bitte Internetverbindung überprüfen und erneut versuchen."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Bitte Internetverbindung überprüfen."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Datenträger scheint voll zu sein."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Wesentliche Komponenten des Installationsprogramms konnten nicht geladen werden. Bitte lade das Installationsprogramm von der offiziellen Website erneut herunter."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Wiederholen in %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Dateiextraktion"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000082 RID: 130
	private static Dictionary<STRING, string> _dict_en_US = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"TRY AGAIN"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"CONTINUE"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"CANCEL"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"BACK"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"REINSTALL"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"LAUNCH"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"UNINSTALL"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"LET'S PARTY"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"QUIT"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"REBOOT NOW"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"REBOOT LATER"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"ONLINE HELP"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0}GB currently available on {1} drive"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Less than 1GB available on {0} drive"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Less than 500MB available on {0} drive"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Download initialization failed due to network issue. Please try again."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Download failed due to network issue. Please try again."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Could not obtain valid update summary. Please try again."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Not enough available disk space."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"An error occurred during installation. Please try again."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Failed to unpack installer resources. Restarting the installer may fix this issue."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Essential components of the installer could not be loaded."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Failed to start installing. Closing the installer and restarting it might fix this issue."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Please redownload it from the "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB is not compatible with your current operating system. Please check G HUB OS compatibility to learn more."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"OFFICIAL WEBSITE."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSION {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Installing in {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB of {1} MB ({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"We are detecting slow download speeds"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Can it wait? We're in the middle of some calibrations"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Making sure your printer and your incognito history are properly connected"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Diverting reactor power"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Summoning a Nyan cat"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"You require more vespene gas"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"I am not doing anything suspicious. Really!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Tessellating the infinity matrix"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"You must construct additional pylons"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"Vitamin D is necessary for the human body"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Frame Shift Drive, Engaged"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"A mouse in the hand is worth two in the bush"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Time flies when you're having fun"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Getting something out of your system"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"This too will pass"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Putting on pants"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Sending our best warrior"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan lookin sus..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Reticulating splines"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Enacting plan for world domination"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"What does this button do?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hey, you. You're finally awake"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"A restart is required to finish installing prerequisites. The installer will reopen once the computer has restarted."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Installation failed."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Initialization failed."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Already installed."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Reinstall G HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Uninstalling."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Uninstall successful."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Error uninstalling."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Quit Installation."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Restart required."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Are you sure you want to quit?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Initializing"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Unpacking"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Installing"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Finalizing"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"By clicking 'install' you agree to the terms of the "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"END USER LICENCE AGREEMENT."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Please wait while we install G HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB is installed and appears to be working properly."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Launch G HUB to check for updates"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Reinstall G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"This software is already installed on this system but looks damaged. Re-installing might fix it."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Reinstalling will first uninstall your existing G HUB software. This operation cannot be cancelled or undone."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB has been successfully uninstalled from the system."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Please wait while we uninstall G HUB. This operation may take some time."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"The previous G HUB installation has been removed. You may proceed with a new installation."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Transfer my current settings"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB Uninstaller"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Critical components are missing: Please reinstall the Microsoft Visual C++ Redistributable 2019 or download and use G HUB installer from the support site."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Please wait while we uninstall G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Removing software components"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Deleting remaining files"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Cleaning up"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"An error happened while uninstalling G HUB: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Try to reboot your computer and run the uninstaller again."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Failed to remove registry keys."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Failed to delete some folders."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Failed to delete some files."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Failed to remove G HUB service."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Failed to stop G HUB processes."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Unknown error (code {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Uninstall"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Uninstalling will remove G HUB from your system. Are you sure you want to proceed? This operation cannot be undone."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech G HUB Installer"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech G HUB Installer Application"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALL"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"EXIT"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"This software already exists on the system. Launch G HUB to look for updates."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"An outdated and incompatible version of Logitech Gaming Software exists on the system. Upgrade or remove it to install G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"DOWNLOADING LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"The new Logitech G HUB software is about to improve your game and device configuration experience…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…building and protecting…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…strafing and boosting…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…hovering and landing…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"DOWNLOAD SUCCESSFUL"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Locked and loaded."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALL AND LAUNCH"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"About"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Quit"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Close Window"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"remaining"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"An error occured during the installation"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Could not download:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Could not obtain a valid update summary."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Could not download: Initialization failed. Please check your internet connection and retry."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Please check your internet connection."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Disk appears to be full."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Essential components of the installer could not be loaded. Please redownloading the installer from the official website."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Retrying in %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Unpacking Files"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000083 RID: 131
	private static Dictionary<STRING, string> _dict_es_ES = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"VOLVER A INTENTAR"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"CONTINUAR"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"CANCELAR"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"POSTERIOR"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"REINSTALAR"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"INICIAR"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"DESINSTALAR"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"HAY QUE CELEBRARLO"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"CERRAR"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"REINICIAR AHORA"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"REINICIAR MÁS TARDE"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"SOPORTE ONLINE"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0}\u00a0GB disponibles actualmente en la unidad {1}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Menos de 1\u00a0GB disponible en la unidad {0}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Menos de 500\u00a0MB disponibles en la unidad {0}"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"La inicialización de la descarga ha fallado por un problema de red. Vuelve a intentarlo."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"La descarga ha fallado por un problema de red. Vuelve a intentarlo."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"No se ha podido obtener un resumen de actualización válido. Vuelve a intentarlo."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"No hay suficiente espacio disponible en el disco duro."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Se ha producido un error durante la instalación. Vuelve a intentarlo."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"No ha sido posible extraer recursos del instalador. El problema podría resolverse reiniciando el instalador."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Algunos componentes esenciales del instalador no se han cargado."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"No ha sido posible iniciar la instalación. El problema podría resolverse cerrando el instalador y reiniciándolo."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Repite la descarga desde el sitio web oficial. "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB no es compatible con tu sistema operativo actual. Comprueba la compatibilidad de G HUB y sistemas operativos para tener más información."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"SITIO WEB OFICIAL."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSIÓN {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Instalando en {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB de {1} MB ({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Hemos detectado lentitud de descarga"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"¿Puede esperar esta acción? Estamos realizando calibraciones"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Comprueba la conexión de la impresora y tu historial de incógnito"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Desviando energía de reactor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Llamando a gato Nyan"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Necesitas más vespeno"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"No estoy haciendo nada sospechoso. ¡De verdad!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Teselando matriz infinita"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Debes construir más pilones"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"La vitamina D es esencial para el cuerpo humano"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Impulsor de distorsión, activado"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Ratón en mano vale más que ciento en libertad"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"El tiempo vuela cuando te lo estás pasando bien"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Despejando tu sistema"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Esto también pasará"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Preparando"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Enviando a nuestro mejor elemento"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cian con pinta sospech..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Reticulando splines"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Poniendo en marcha plan para dominar el mundo"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"¿Qué hace este botón?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"¡Eh, tú! Por fin te has despertado"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Se requiere un reinicio para finalizar la instalación de requisitos previos. El instalador volverá a abrirse una vez se haya reiniciado el ordenador."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Error de instalación."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Error de inicialización."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Instalación ya hecha."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"¿Reinstalar G HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Desinstalando."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Desinstalación completada."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Error de desinstalación."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Cerrar instalación"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Es necesario reiniciar."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"¿Seguro que quieres cerrar?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Inicializando"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Extrayendo"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Instalando"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Finalizando"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Al hacer clic en Instalar, aceptas los términos del "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"CONTRATO DE LICENCIA DE USUARIO FINAL"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Espera a que instalemos G HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB se ha instalado y parece que funciona correctamente."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Inicia G HUB para buscar actualizaciones"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Reinstalar G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Este software ya está instalado en este sistema pero parece estar dañado. El problema podría resolverse con una reinstalación."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Con la reinstalación, primero se desinstalará el software G HUB existente. Esta operación no puede cancelarse ni deshacerse."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB se ha desinstalado del sistema."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Espera a que desinstalemos G HUB. Esta operación podría tardar."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Se ha eliminado la instalación anterior de G HUB. Puedes iniciar una nueva instalación."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Transferir mi configuración actual"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Desinstalador de G HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Faltan componentes decisivos: Vuelve a instalar Microsoft Visual C++ Redistributable 2019 o descarga y usa el instalador de G HUB desde el sitio de asistencia."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Espera a que desinstalemos G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Quitando componentes de software"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Eliminando archivos restantes"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Limpieza"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Se ha producido un error al desinstalar G HUB: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Reinicia el ordenador y vuelve a ejecutar el desinstalador."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"No se han podido eliminar claves del registro."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"No se han podido eliminar algunas carpetas."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"No se han podido eliminar algunos archivos."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"No se ha podido eliminar el servicio G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"No se han podido detener procesos de G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Error desconocido (código {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Desinstalar"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"La desinstalación eliminará G HUB de tu sistema. ¿Seguro que quieres continuar con la acción? Esta operación no puede deshacerse."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Instalador de Logitech G HUB"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Aplicación de instalación de Logitech G HUB"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALAR"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"SALIR"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Este software ya existe en el sistema. Inicia G HUB para buscar actualizaciones."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"El sistema tiene instalada una versión desfasada e incompatible de Logitech Gaming Software. Actualízala o elimínala para instalar G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"DESCARGANDO LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"El nuevo software Logitech G HUB está a punto de mejorar tu experiencia de configuración de juegos y dispositivos…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…construyendo y protegiendo…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…arrasando y reforzando…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…sobrevolando y aterrizando…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"DESCARGA REALIZADA"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Lista para usar."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALAR E INICIAR"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Acerca de"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Salir"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Cerrar ventana"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"restante(s)"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Se ha producido un error durante la instalación"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"No se pudo descargar:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"No se pudo obtener un resumen de actualización válido."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"No se pudo descargar: Error de inicialización. Comprueba la conexión a Internet y vuelve a intentarlo."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Comprueba la conexión a Internet."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Parece que el disco esta lleno."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Algunos componentes esenciales del instalador no se han cargado. Vuelve a descargar el instalador desde el sitio web oficial."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Reintentando en %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Extracción de archivos"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000084 RID: 132
	private static Dictionary<STRING, string> _dict_fi_FI = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"YRITÄ UUDELLEEN"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"JATKA"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"PERUUTA"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"TAKANA"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"ASENNA UUDELLEEN"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"KÄYNNISTÄ"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"POISTA ASENNUS"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"BILEET PYSTYYN"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"LOPETA"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"KÄYNNISTÄ UUDELLEEN NYT"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"KÄYNNISTÄ UUDELLEEN MYÖHEMMIN"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"VERKKO-OHJE"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0} Gt vapaana asemalla {1}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Alle 1 Gt vapaana asemalla {0}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Alle 500 Gt vapaana asemalla {0}"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Latauksen aloittaminen epäonnistui verkko-ongelman takia. Yritä uudelleen."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Lataus epäonnistui verkko-ongelman takia. Yritä uudelleen."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Kelvollista päivitysyhteenvetoa ei saatu. Yritä uudelleen."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Vapaa levytila ei riitä."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Asennuksen aikana ilmeni virhe. Yritä uudelleen."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Asennusohjelman resurssien purkaminen epäonnistui. Asennusohjelman käynnistäminen uudelleen voi ratkaista ongelman."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Asennusohjelman tärkeitä komponentteja ei voitu ladata."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Asennuksen aloittaminen epäonnistui. Asennusohjelman sulkeminen ja käynnistäminen uudelleen voi ratkaista ongelman."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Lataa se uudelleen "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB ei ole yhteensopiva nykyisen käyttöjärjestelmäsi kanssa. Tarkista G HUBIN käyttöjärjestelmäyhteensopivuus saadaksesi lisätietoja."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"VIRALLISELTA VERKKOSIVUSTOLTA."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSIO {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Asennetaan kohteeseen {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} Mt / {1} Mt ({2} Mt/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Lataus edistyy hitaasti"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Voiko lataus odottaa? Suoritamme parhaillaan kalibrointia"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Varmistetaan, että tulostin ja incognito-historia on yhdistetty kunnolla"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Reaktoritehoa ohjataan muualle"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Nyan-kissaa kutsutaan"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Tarvitset lisää vespene-kaasua."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"En minä tee mitään epäilyttävää. Ihan tosi!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Tesselloidaan äärettömyysmatriisia"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Sinun on rakennettava lisää pyloneja"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"Vitamin D on välttämätöntä ihmiskeholle"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Frame Shift Drive käytössä"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Parempi hiiri kädessä kuin kymmenen oksalla"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Aika rientää, kun on hauskaa"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Hankkiudutaan turhasta eroon"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Väliaikaista kaikki on vain"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Vedetään housuja jalkaan"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Lähetetään parasta soturiamme"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Syaani näyttää epäilyttävältä..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Retikuloidaan splinejä"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Toteutetaan maailmanvalloitussuunnitelmaa"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Mitä tästä nappulasta tapahtuu?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hei. Olet vihdoin herännyt"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Tietokone on käynnistettävä uudelleen edellytysten asennuksen viimeistelemiseksi. Asennusohjelma käynnistyy uudelleen, kun tietokone on käynnistetty uudelleen."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Asennus epäonnistui."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Alustus epäonnistui."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Asennus on jo tehty."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Asennetaanko G HUB uudelleen?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Poistetaan asennusta."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Asennus poistettiin."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Virhe poistettaessa asennusta."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Lopeta asennus."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Tarvitaan uudelleenkäynnistys."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Haluatko varmasti lopettaa?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Alustetaan"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Puretaan"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Asennetaan"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Viimeistellään"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Napsauttamalla Asenna hyväksyt "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"KÄYTTÖOIKEUSSOPIMUKSEN."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Odota, että G HUB asennetaan."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB asennettiin, ja se näyttää toimivan oikein."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Käynnistä G HUB etsiäksesi päivityksiä"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Asenna G HUB uudelleen"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Ohjelmisto on jo asennettu tähän järjestelmään, mutta se näyttää vioittuneelta. Uudelleenasennus voi korjata asian."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Uudelleenasennuksessa nykyinen G HUB -ohjelmisto poistetaan ensin. Toimintoa ei voi peruuttaa tai kumota."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB -ohjelmiston asennus poistettiin järjestelmästä."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Odota, että G HUB -ohjelmiston asennus poistetaan. Tässä voi kestää jonkin aikaa."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Edellinen G HUB -asennus on poistettu. Voit suorittaa uuden asennuksen."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Siirrä nykyiset asetukset"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB -asennuksen poisto-ohjelma"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Tärkeitä osia puuttuu: Asenna Microsoft Visual C++ 2019:n edelleenjaeltava paketti uudelleen tai lataa G HUB -asennusohjelma tukisivustolta ja käytä sitä."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Odota, että G HUB -ohjelmiston asennus poistetaan."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Poistetaan ohjelmiston osia"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Poistetaan jäljellä olevia tiedostoja"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Puhdistetaan"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Virhe G HUB -ohjelmiston asennuksen poistamisessa: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Käynnistä tietokone uudelleen ja suorita asennuksen poisto-ohjelma uudelleen."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Rekisteriavaimia ei voinut poistaa."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Joitakin kansioita ei voinut poistaa."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Joitakin tiedostoja ei voinut poistaa."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"G HUB -palvelua ei voinut poistaa."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"G HUB -prosesseja ei voinut pysäyttää."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Tuntematon virhe (koodi {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Poista asennus"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Jos poistat asennuksen, G HUB poistetaan järjestelmästä. Haluatko varmasti jatkaa? Toimintoa ei voi kumota."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech G HUB -asennusohjelma"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech G HUB -asennussovellus"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"ASENNA"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"POISTU"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Ohjelmisto on jo järjestelmässä. Käynnistä G HUB etsiäksesi päivityksiä."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"Järjestelmässä on Logitech Gaming Softwaren vanhentunut ja epäyhteensopiva versio. Päivitä tai poista se, jos haluat asentaa G HUBin."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"LADATAAN LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Uusi Logitech G HUB -ohjelmisto parantaa juuri pelaamis- ja laitekokoonpanokokemustasi…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…rakentaminen ja suojelu…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…streiffataan ja buustataan…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…leijuminen ja laskeutuminen…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"LATAUS ONNISTUI"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Ladattu ja valmis."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"ASENNA JA KÄYNNISTÄ"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Tietoja"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Lopeta"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Sulje ikkuna"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"jäljellä"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Asennuksen aikana ilmeni virhe"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Lataus ei onnistunut:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Kelvollista päivitysyhteenvetoa ei saatu."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Lataus ei onnistunut: Alustus epäonnistui. Tarkista verkkoyhteys ja yritä uudelleen."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Lataus ei onnistunut: Tarkista verkkoyhteys."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Levy vaikuttaa olevan täynnä."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Asennusohjelman tärkeitä komponentteja ei voitu ladata. Lataa asennusohjelma uudelleen viralliselta verkkosivustolta."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Yritetään uudestaan %d kuluttua."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Tiedostojen purkaminen"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000085 RID: 133
	private static Dictionary<STRING, string> _dict_fr_FR = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"RÉESSAYER"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"CONTINUER"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"ANNULER"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"ARRIÈRE"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"RÉINSTALLER"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"LANCER"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"DÉSINSTALLER"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"FAISONS LA FÊTE"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"QUITTER"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"REDÉMARRER MAINTENANT"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"REDÉMARRER PLUS TARD"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"AIDE EN LIGNE"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0} Go actuellement disponibles sur le disque {1}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Moins de 1 Go disponible sur le disque {0}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Moins de 500 Mo disponibles sur le disque {0}"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Échec de l’initialisation du téléchargement en raison d’un problème réseau. Réessaie."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Échec du téléchargement en raison d’un problème réseau. Réessaie."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Impossible d'obtenir un résumé valide de la mise à jour. Réessaie."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Espace disque disponible insuffisant."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Une erreur s'est produite lors de l'installation. Réessaie."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Échec de la décompression des ressources du programme d’installation. Relance le programme d’installation pour essayer de corriger le problème."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Les composants essentiels du programme d'installation n'ont pas pu être chargés."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Échec du lancement de l’installation. Ferme et relance le programme d’installation pour tenter de résoudre le problème."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Retélécharge-le à partir du "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB est incompatible avec ton système d’exploitation actuel. Consulte la compatibilité de G HUB avec les systèmes d’exploitation pour en savoir plus."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"SITE WEB OFFICIEL."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSION {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Installation dans {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} Mo sur {1} Mo ({2}Mo/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Nous avons détecté une faible vitesse de téléchargement"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Est-ce que cela peut attendre? Nous sommes en plein réglage"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Assure-toi que ton imprimante et que ton historique de navigation incognito soient activés"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Réaffectation de la puissance du réacteur"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Invocation du Nyan Cat"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Tu as besoin de plus de gaz vespène"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Je ne fais rien de suspect. Je vous jure!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Assemblage de la matrice"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Tu dois construire davantage de pylônes"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"La vitamine D est essentielle pour notre organisme"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Allez, on passe à la vitesse supérieure!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"L’avantage d’une souris informatique, c’est qu’elle risque pas de grignoter tes fils électriques."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Le temps passe tellement vite quand on s’amuse"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"On sort quelque chose du système"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Ça va bien se passer"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"On se prépare"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Notre meilleur guerrier est au front"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Le cyan a l’air suspect..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"On enlève les emballages"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Mise en place de notre plan pour dominer l’Univers"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Il fait quoi ce bouton?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Salut, toi! T’es enfin réveillé!"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Il est nécessaire de redémarrer pour finir l’installation des conditions requises. Le programme d’installation sera ouvert à nouveau une fois l’ordinateur redémarré."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Échec de l'installation"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"L'initialisation a échoué."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Déjà installé."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Réinstaller G HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Désinstallation en cours."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Désinstallation réussie."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Erreur lors de la désinstallation."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Quitter l'installation."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Redémarrage nécessaire."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Es-tu sûr de vouloir quitter?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Initialisation en cours"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Décompression en cours"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Installation en cours"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Finalisation en cours"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"En cliquant sur Installer, tu acceptes les termes du "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"CONTRAT DE LICENCE UTILISATEUR FINAL"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Merci de patienter pendant que nous installons G HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB est installé et semble fonctionner correctement."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Lance G HUB pour rechercher les mises à jour"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Réinstaller G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Ce logiciel est déjà installé sur ce système mais semble corrompu. Une réinstallation peut corriger ce problème."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"La réinstallation désinstallera tout d’abord ton logiciel G HUB existant. Cette opération ne peut être annulée."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB a été désinstallé de ton système."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Merci de patienter pendant que nous désinstallons G HUB. Cette opération peut prendre un certain temps."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"L’installation précédente de G HUB a été supprimée. Tu peux désormais le réinstaller."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Transférer mes paramètres actuels"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Programme de désinstallation de G HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Des éléments critiques manquent à l’appel: Réinstalle le package redistribuable Microsoft Visual C++ 2019, ou télécharge et utilise le programme d’installation G HUB à partir du site de support."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Merci de patienter pendant que nous désinstallons G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Suppression des composants logiciels"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Suppression des fichiers résiduels"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Nettoyage"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Une erreur est survenue lors de la désinstallation de G HUB: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Essaie de redémarrer ton ordinateur et de relancer le programme de désinstallation."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Échec de la suppression des clés de registre."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Échec de la suppression de certains dossiers."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Échec de la suppression de certains fichiers."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Échec de la suppression du service G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Échec de l’arrêt des processus G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Erreur inconnue (code {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Désinstaller"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"La désinstallation supprimera G HUB de ton système. Es-tu sûr de vouloir continuer? Cette opération ne peut être annulée."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Installeur de Logitech\u00a0G\u00a0HUB"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Application d'installation de Logitech\u00a0G\u00a0HUB"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALLER"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"QUITTER"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Ce logiciel existe déjà sur le système. Lance G HUB pour rechercher les mises à jour"
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"Une version obsolète et incompatible de l'Assistant pour jeux vidéo de Logitech est présente sur le système. Mets-le à niveau ou supprime-le pour pouvoir installer G\u00a0HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"TÉLÉCHARGEMENT DE LOGITECH\u00a0G\u00a0HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Le nouveau logiciel Logitech G\u00a0HUB va bientôt améliorer ton expérience de jeu et la configuration des dispositifs..."
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…construire et protéger…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…bombarder et remonter…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…voler et atterrir…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"TÉLÉCHARGEMENT TERMINÉ"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Paré au combat."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALLER ET LANCER"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"À propos"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Quitter"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Fermer la fenêtre"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"restant"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Une erreur s'est produite lors de l'installation"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Impossible de télécharger:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Impossible d'obtenir un résumé valide de la mise à jour."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Impossible de télécharger: L'initialisation a échoué. Vérifie ta connexion Internet et réessaie."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Vérifie ta connexion Internet."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Il semble que le disque est saturé."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Les composants essentiels du programme d'installation n'ont pas pu être chargés. Retélécharge le programme d’installation à partir du site Web officiel."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Réessayer dans %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Décompression de fichiers"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000086 RID: 134
	private static Dictionary<STRING, string> _dict_hu_HU = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"PRÓBÁLD ÚJRA"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"FOLYTATÁS"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"MÉGSE"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"HÁTSÓ"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"ÚJRATELEPÍTÉS"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"INDÍTÁS"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"ELTÁVOLÍTÁS"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"BULIZZUNK"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"KILÉPÉS"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"ÚJRAINDÍTÁS MOST"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"ÚJRAINDÍTÁS KÉSŐBB"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"INTERNETES SÚGÓ"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"Jelenleg {0} GB szabad a(z) {1} meghajtón"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Kevesebb mint 1 GB szabad a(z) {0} meghajtón"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Kevesebb mint 500 MB szabad a(z) {0} meghajtón"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"A letöltés inicializálása hálózathiba miatt meghiúsult. Próbáld újra."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"A letöltés hálózathiba miatt meghiúsult. Próbáld újra."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Nem sikerült lekérni érvényes frissítésösszesítést. Próbáld újra."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Nincs elég szabad hely a merevlemezen."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Hiba történt a telepítés során Próbáld újra."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Nem sikerült kicsomagolni a telepítési forrásokat. A telepítőprogram újraindítása segíthet megoldani a problémát."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"A telepítő lényeges összetevői nem tölthetők be."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"A telepítést nem sikerült elindítani. A telepítőprogram bezárása és újraindítása segíthet megoldani a problémát."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Töltsd le újból a "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"A G HUB nem kompatibilis a jelenlegi operációs rendszereddel. A részletekről a G HUB rendszer-kompatibilitási információjában olvashatsz."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"HIVATALOS WEBHELYRŐL."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERZIÓ {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Telepítés ide: {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB/{1} MB ({2} MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Lassúnak találjuk a letöltési sebességet."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Várjak? Egy kalibrálás közepén tartunk."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Ellenőrizd, megfelelően van-e csatlakoztatva a nyomtató és az inkognitóelőzmények."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"A reaktor teljesítményének eltérítése"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Egy nyan macska odahívása"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Több veszpéngázra van szükség"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Nem csinálok semmi gyanúsat. Tényleg!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"A végtelen mátrix feltöltése"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"További tartókat kell létrehoznod"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"A D-vitaminra szüksége van az emberi testnek"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Képkockamozgatás, bekapcsolva"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Jobb ma egy veréb, mint holnap egy túzok"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Szórakozás közben repül az idő"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Hozz ki valamit a rendszeredből"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Ez is elmúlik"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Nadrághúzás"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"A legjobb harcosunkat küldjük"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"A cián kinézete gyan…"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"A görbék befedése hálóval"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"A világuralmi terv bemutatása"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Mire jó ez a gomb?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hé, te! Végre ébren vagy"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Az előfeltételek telepítésének befejezéséhez újraindítás szükséges. A számítógép újraindulása után a telepítő újra megnyílik."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"A telepítés nem sikerült."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Az inicializálás nem sikerült."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Már telepítve van."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Újratelepíted a G HUB szoftvert?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Eltávolítás."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Az eltávolítás sikerült."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Az eltávolítás során hiba történt."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Kilépés telepítőből"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Újraindítás szükséges."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Biztos ki akarsz lépni?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Inicializálás"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Kicsomagolás"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Telepítés"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Véglegesítés"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"A Telepítés lehetőségre kattintva elfogadod a "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"VÉGFELHASZNÁLÓI LICENCSZERZŐDÉS FELTÉTELEIT."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Várj, amíg a G HUB telepítése zajlik."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"A G HUB telepítve van, és úgy tűnik, hibátlanul működik."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"A G HUB elindítása és frissítések keresése"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"A G HUB újratelepítése"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Ez a szoftver már telepítve van erre a rendszerre, de sérültnek tűnik. Az újratelepítés megjavíthatja."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Az újratelepítés során a rendszer előbb eltávolítja a G HUB szoftvert. Ez a művelet nem szakítható meg és nem vonható vissza."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"A G HUB sikeresen eltávolítva a rendszerről."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Várj, amíg a G HUB eltávolítása zajlik. Ez a művelet eltarthat egy darabig."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"A korábban telepített G HUB eltávolítva. Új telepítéssel érdemes folytatnod."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"A jelenlegi beállítások átvitele"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB-eltávolító"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Kritikus összetevők hiányoznak: Telepítsd újra a Microsoft Visual C++ Redistributable 2019 csomagot, vagy töltsd le és használd a G HUB telepítőjét a támogatási webhelyről."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Várj, amíg a G HUB eltávolítása zajlik."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Szoftverösszetevők eltávolítása"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"A megmaradt fájlok eltávolítása"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Tisztítás"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Hiba történt a G HUB eltávolítása során: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Próbáld meg újraindítani a számítógépet, majd újra futtatni az eltávolítóprogramot."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Nem sikerült eltávolítani a beállításkulcsokat."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Nem sikerült törölni néhány mappát."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Nem sikerült törölni néhány fájlt."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Nem sikerült eltávolítani a G HUB szolgáltatást."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Nem sikerült leállítani a G HUB-folyamatokat."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Ismeretlen hiba (hibakód: {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Eltávolítás"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Az eltávolítás törli a rendszerről a G HUB szoftvert. Biztosan folytatod? Ez a művelet nem vonható vissza."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech G HUB Telepítő"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech G HUB Telepítő alkalmazás"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"TELEPÍTÉS"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"KILÉPÉS"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Ez a szoftver már telepítve van a rendszerre. A G HUB elindítása és frissítések keresése."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"A Logitech Gaming Software lejárt és nem kompatibilis verziója telepítve van a rendszerben. Ezt a G HUB telepítéshez frissíteni kell vagy el kell távolítani."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"LOGITECH G HUB LETÖLTÉSE"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Az új Logitech G HUB szoftverrel szintet léphet a játék- és eszközbeállítási élménye…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…építés és védelem…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…oldalazás és erősítés…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…felemelkedés és landolás…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"LETÖLTÉS SIKERES"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Zárolva és betöltve."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"TELEPÍTÉS ÉS INDÍTÁS"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Névjegy"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Kilépés"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Ablak bezárása"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"van hátra"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Hiba történt a telepítés során"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Sikertelen letöltés:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Nem sikerült beolvasni érvényes frissítésösszesítést."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Sikertelen letöltés: Az inicializálás nem sikerült. Ellenőrizd az internetkapcsolatot, és ismételd meg."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Ellenőrizd az internetkapcsolatot."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Úgy tűnik, a lemez megtelt."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"A telepítő lényeges összetevői nem tölthetők be. Töltsd le újra a telepítőprogramot a hivatalos webhelyről."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Ismétlés ebben: %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"A fájlok kibontása"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000087 RID: 135
	private static Dictionary<STRING, string> _dict_it_IT = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"RIPROVA"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"CONTINUA"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"ANNULLA"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"POSTERIORE"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"REINSTALLA"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"AVVIA"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"DISINSTALLA"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"INIZIAMO"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"ESCI"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"RIAVVIA ORA"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"RIAVVIA IN SEGUITO"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"GUIDA IN LINEA"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0} GB disponibile sull’unità {1}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Meno di 1 GB disponibile sull’unità {0}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Meno di 500 MB disponibili sull’unità {0}"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Inizializzazione download non riuscita a causa di problemi di rete. Riprova."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Download non riuscito a causa di problemi di rete. Riprova."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Impossibile ottenere un riepilogo aggiornamenti valido. Riprova."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Spazio su disco insufficiente."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Si è verificato un errore durante l'installazione. Riprova."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Impossibile estrarre risorse del programma di installazione. Riavviare il programma di installazione per risolvere il problema."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Non è stato possibile caricare alcuni componenti essenziali del programma di installazione."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Impossibile avviare l’installazione. Chiudere e riavviare il programma di installazione per risolvere il problema."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Scaricalo di nuovo dal "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB non è compatibile con il tuo sistema operativo attuale. Verifica la compatibilità del sistema operativo G HUB per ulteriori informazioni."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"SITO WEB UFFICIALE."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSIONE {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Installazione in {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB di {1} MB ({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Velocità di download bassa"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Attendere? Stiamo calibrando alcuni parametri"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Ci stiamo accertando che la tua stampante e la modalità anonima della cronologia siano collegate correttamente"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Deviazione potenza reattore"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Richiamo Nyan cat"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Hai bisogno di più gas vespene"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Non sto facendo niente di sospetto. Davvero!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Creazione della corrispondenza matrice infinita"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Devi costruire altri pylon"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"La vitamina D è necessaria all’organismo"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Frame Shift Drive, innestato"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Meglio un uovo oggi che una gallina domani"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Il tempo vola quando ci si diverte"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Fallo e non pensarci più"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Anche questo passerà"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Mettersi i pantaloni"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Mandiamo il nostro migliore guerriero"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan sembra sospetto"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Sto caricando"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Diamo il via al piano per dominare il mondo"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"A cosa serve questo pulsante?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Ciao! Ti sei svegliato, finalmente"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Riavvio necessario per terminare i prerequisiti di installazione. Il programma di installazione si riaprirà al termine del riavvio del computer."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Installazione non riuscita."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Installazione non riuscita."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Già installato"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Reinstallare G HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Disinstallazione in corso."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Disinstallazione avvenuta correttamente."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Errore di disinstallazione."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Esci da installazione."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Riavvio richiesto."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Uscire?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Inizializzazione"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Estrazione in corso"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Installazione in corso"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Finalizzazione in corso"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Facendo clic su installa accetti i termini del "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"CONTRATTO DI LICENZA CON L'UTENTE FINALE."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Attendi l’installazione di G HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB è installato e funziona correttamente."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Avvia G HUB per verificare disponibilità aggiornamenti"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Reinstalla G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Il software è già installato, ma sembra corrotto. Reinstallare per risolvere il problema."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Reinstallando verrà disinstallato il software G HUB presente sul dispositivo. L’operazione non può essere annullata."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB è stato disinstallato correttamente dal sistema."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Attendere la disinstallazione di G HUB. Potrebbe occorrere qualche minuto."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Installazione di G HUB precedente rimossa. Procedere con una nuova installazione."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Trasferisci le mie impostazioni."
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Programma di disinstallazione G HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Componenti critici mancanti: Reinstallare Microsoft Visual C++ Redistributable 2019 o scaricare e utilizzare il programma di installazione G HUB dal sito di assistenza."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Attendere la disinstallazione di G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Rimozione componenti software"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Eliminazione file rimanenti"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Pulizia in corso"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Si è verificato un errore durante la disinstallazione di G HUB: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Prova a riavviare il computer ed eseguire di nuovo lo strumento di disinstallazione."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Impossibile rimuovere le chiavi di registro."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Impossibile eliminare alcune cartelle."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Impossibile eliminare alcuni file."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Impossibile rimuovere il servizio G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Impossibile arrestare i processi G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Errore sconosciuto (codice {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Disinstalla"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Procedendo con la disinstallazione G HUB verrà rimosso dal sistema. Procedere? L’operazione non può essere annullata."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Programma di installazione Logitech G HUB"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Applicazione di installazione Logitech G HUB"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALLA"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"ESCI"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Questo software esiste già nel sistema. Avvia G HUB per verificare la disponibilità di aggiornamenti."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"Sul sistema è presente una versione obsoleta e non compatibile di Logitech Gaming Software. Esegui l'upgrade o rimuovilo per installare G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"DOWNLOAD DI LOGITECH G HUB IN CORSO"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Il nuovo software Logitech G HUB sta per migliorare la tua esperienza di configurazione di giochi e dispositivi..."
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"...costruendo e proteggendo..."
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"...esperienza ottimizzata..."
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…esplorazione e atterraggio…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"DOWNLOAD EFFETTUATO CORRETTAMENTE"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Bloccato e caricato."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALLA E AVVIA"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Informazioni su"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Esci"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Chiudi finestra"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"rimanenti"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Si è verificato un errore durante l'installazione"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Impossibile eseguire il download:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Impossibile ottenere un riepilogo aggiornamenti valido."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Impossibile eseguire il download: Installazione non riuscita. Verifica la connessione Internet e riprova."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Verifica la connessione Internet."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Spazio su disco insufficiente."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Non è stato possibile caricare alcuni componenti essenziali del programma di installazione. Scarica nuovamente il programma di installazione dal sito Web ufficiale."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Nuovo tentativo fra %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Estrazione di file"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000088 RID: 136
	private static Dictionary<STRING, string> _dict_ja_JP = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGICOOL G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"再試行"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"続行"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"キャンセル"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"後"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"再インストール"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"起動"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"アンインストール"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"パーティーを開始"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"終了"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"今すぐ再起動"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"後で再起動"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"オンラインヘルプ"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{1} ドライブでは現在 {0}GB 利用可能です"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"{0} ドライブでは 1GB 未満が利用可能です"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"{0} ドライブでは 500MB 未満が利用可能です"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"ネットワークの問題により、ダウンロードの初期化に失敗しました。再試行してください。"
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"ネットワークの問題により、ダウンロードに失敗しました。再試行してください。"
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"有効な更新概要を取得できませんでした。再試行してください。"
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"十分なディスク空き容量がありません。"
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"インストール中にエラーが発生しました。再試行してください。"
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"インストーラーリソースの解凍に失敗しました。インストーラーを再起動すると、この問題が解決する可能性があります。"
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"インストーラーの重要なコンポーネントを読み込めませんでした。"
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"インストールを開始できませんでした。インストーラーを閉じて再起動すると、この問題が解決する可能性があります。"
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"公式ウェブサイトから再度 "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB は現在お使いのオペレーティングシステムに対応していません。詳細は、G HUB OS の互換性を確認してください。"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"ダウンロードしてください。"
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"バージョン {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"{0} でインストールしています"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB / {1} MB（{2}MB/秒）"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"ダウンロード速度が遅くなっています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"待機しますか？現在キャリブレーションを行っています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"プリンターと匿名履歴が適切に接続されていることを確認しています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"原子炉出力を転用しています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Nyan cat を呼び出しています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"vespene gas がもっと必要です"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"私は何も疑わしいことはしていません。本当です！"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"無限マトリクスを平面充填しています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"追加のパイロンを建築する必要があります"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"人間の身体にはビタミン D が必要です"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"フレームシフトドライブ、使用中"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"手中の一羽はやぶ中の二羽の値打ちがある"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"楽しい時間はあっという間に過ぎる"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"システムから何かを取得しています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"これもまた過ぎ去るもの"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"ズボンを履く"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"最高の戦士を送っています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan lookin sus..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"スプラインを再計算しています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"世界支配の計画を制定しています"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"このボタンの機能："
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"こんにちは。あなたはついに起きました"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"インストール要件を終了するには、再起動が必要です。コンピュータの再起動後、インストーラーが再度開きます。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"インストールに失敗しました。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"初期化に失敗しました。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"既にインストールされています。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"G HUB を再インストールしますか？"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"アンインストールしています。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"アンインストールが完了しました。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"アンインストールエラー。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"インストールを終了します。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"再起動が必要です。"
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"終了しますか？"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"初期化中"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"解凍中"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"インストール中"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"終了しています"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"[インストール] をクリックすることで、あなたは "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"使用許諾契約の条件に同意したことになります。"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logicool.co.jp/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"G HUB のインストール中です。しばらくお待ちください。"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB がインストールされ、適切に動作しているようです。"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"G HUB を起動して更新をチェック"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"G HUB を再インストール"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"このソフトウェアはすでにこのシステムにインストールされていますが、破損しているようです。再インストールによって修復される可能性があります。"
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"再インストールすると、既存の G HUB ソフトウェアがまずアンインストールされます。この操作はキャンセルしたり、元に戻したりすることはできません。"
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB がシステムから正常にアンインストールされました。"
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"G HUB のアンインストール中です。しばらくお待ちください。この操作にはしばらく時間がかかる場合があります。"
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"以前の G HUB のインストールが削除されました。新しいインストールを進めることができます。"
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"現在の設定を転送"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB アンインストーラー"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"重要なコンポーネントがありません：Microsoft Visual C++ 再頒布可能パッケージ 2019 を再インストールするか、またはサポートサイトから G HUB インストーラーをダウンロードして使用してください。"
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"G HUB のアンインストール中です。しばらくお待ちください。"
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"ソフトウェアコンポーネントを削除しています"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"残りのファイルを削除しています"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"クリーンアップしています"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"G HUB のアンインストール中にエラーが発生しました："
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" コンピュータを再起動して、アンインストーラーを再度実行してください。"
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"レジストリキーを削除できませんでした。"
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"一部のフォルダを削除できませんでした。"
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"一部のファイルを削除できませんでした。"
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"G HUB サービスを削除できませんでした。"
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"G HUB プロセスを停止できませんでした。"
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"不明なエラー（コード {0}）。"
		},
		{
			STRING.UNINSTALLER_TITLE,
			"アンインストール"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"アンインストールによって、システムから G HUB が削除されます。続行しますか？この操作は元に戻せません。"
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logicool G HUB インストーラー"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logicool G HUB インストーラー アプリケーション"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"インストール"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"終了"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"このソフトウェアはお使いのシステムにすでにインストールされています。G HUB を起動して更新を探してください。"
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"Logicool ゲームソフトウェアの旧バージョンまたは互換性のないバージョンがシステムに存在します。アップグレードするか、または削除して G HUB をインストールしてください。"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"LOGICOOL G HUB をダウンロードしています"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"新しい Logicool G HUB ソフトウェアが、ゲーミング体験とデバイス構成を強化します…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…ビルドと防衛…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…機銃掃射とブースティング…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…ホバリングとランディング…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"ダウンロードが完了しました"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"ロック、ロードされています。"
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"インストールと起動"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"バージョン情報"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"終了"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"ウィンドウを閉じる"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"残り"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"インストール中にエラーが発生しました"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"ダウンロードできませんでした："
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"有効な更新概要を取得できませんでした。"
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"ダウンロードできませんでした：初期化に失敗しました。インターネット接続を確認して再試行してください。"
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"インターネット接続を確認してください。"
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"ディスクが一杯のようです。"
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"インストーラーの重要なコンポーネントを読み込めませんでした。公式ウェブサイトからインストーラーを再度ダウンロードしてください。"
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"%d で再試行しています。"
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"ファイル抽出"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000089 RID: 137
	private static Dictionary<STRING, string> _dict_ko_KR = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"다시 시도하기"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"계속"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"취소"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"후면"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"재설치"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"실행"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"제거"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"신나는 파티"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"종료"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"지금 재부팅"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"나중에 재부팅"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"온라인 도움말"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"현재 {1} 드라이브에 {0}GB 이용 가능"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"{0} 드라이브 이용 가능 공간 1GB 미만"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"{0} 드라이브 이용 가능 공간 500MB 미만"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"네트워크 문제로 인해 다운로드 설치에 실패했습니다. 다시 시도하십시오."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"네트워크 문제로 인해 다운로드에 실패했습니다. 다시 시도하십시오."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"유효한 업데이트 요약을 가져올 수 없습니다. 다시 시도하십시오."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"디스크 여유 공간이 부족합니다."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"설치 중 오류가 발생했습니다. 다시 시도하십시오."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"설치 프로그램 리소스 압축 해제에 실패했습니다. 설치 프로그램을 다시 시작하면 문제가 해결될 수도 있습니다."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"설치 프로그램의 필수 구성요소를 로드할 수 없습니다."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"설치를 시작하지 못했습니다. 설치 프로그램을 종료하고 다시 시작하면 문제가 해결될 수도 있습니다."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"공식 웹사이트에서 "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB의 다음 업데이트는 귀하의 현재 운영 체제와 호환되지 않습니다. 자세한 내용은 G HUB OS 호환성을 확인하세요."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"다시 다운로드하세요."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"버전 {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"{0}에 설치 중"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB/{1} MB({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"다운로드 속도가 느립니다."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"대기할 수 있습니까? 지금은 설정이 진행 중입니다."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"프린터와 익명 기록이 적절히 연결되어 있는지 확인하세요."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"원자로 전원 전환 중"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Nyan cat 소환 중"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"베스핀 가스가 더 필요합니다"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"수상한 행동을 하고 있지 않아요. 정말입니다!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"무한 매트리스 모자이크 중"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"철탑을 추가로 지어야 합니다"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"인체에는 비타민 D가 필요합니다"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"프레임 시프트 드라이브, 연결"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"손안에 있는 쥐 한 마리가 덤불 속 두 마리보다 낫다"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"즐거울 때는 시간 가는 줄 모르게 되죠"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"시스템에서 무언가를 꺼내는 중"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"이것도 지나갈 겁니다"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"바지 입는 중"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"최고의 전사를 보내는 중"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan이 수상합니다..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"도로망 표시 중"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"세계 정복을 위한 계획 짜는 중"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"이 버튼은 어떤 역할을 하나요?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"안녕하세요. 드디어 깨어났군요."
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"필수 요소 설치를 완료하려면 다시 시작해야 합니다. 컴퓨터가 다시 시작하면 설치 프로그램이 다시 열립니다."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"설치 실패."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"초기화 실패."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"이미 설치되어 있습니다."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"G HUB를 다시 설치할까요?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"제거하는 중"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"제거가 완료되었습니다."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"제거 중 오류 발생"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"설치 종료."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"다시 시작 필요."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"정말 종료하시겠습니까?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"초기화 중"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"압축 해제 중"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"설치 중"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"마무리 중"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"‘설치’를 클릭하면 다음의 약관에 동의하는 것입니다. "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"최종 사용자 라이센스 계약"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"G HUB를 설치하는 동안 잠시 기다려주세요."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB가 설치되었으며 잘 작동하고 있습니다."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"G HUB를 실행하여 업데이트 확인"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"G HUB 재설치"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"이 소프트웨어가 이미 시스템에 설치되어 있지만, 손상된 것 같습니다. 재설치를 하면 문제가 해결될 수 있습니다."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"재설치 시 먼저 기존 G HUB 소프트웨어를 제거하게 됩니다. 이 작업은 취소하거나 돌이킬 수 없습니다."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB가 시스템에서 성공적으로 제거되었습니다."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"G HUB를 제거하는 동안 잠시 기다려주세요. 이 작업에는 약간의 시간이 소요될 수 있습니다."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"이전에 설치된 G HUB가 제거되었습니다. 새로 설치를 진행하셔도 됩니다."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"현재 설정 이전"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB 설치 제거 프로그램"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"중요한 요소가 누락되었습니다. Microsoft Visual C++ Redistributable 2019를 다시 설치하거나 지원 사이트에서 G HUB 설치 프로그램을 다운로드하십시오."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"G HUB를 제거하는 동안 잠시 기다려주세요."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"소프트웨어 구성 요소 제거 중"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"남은 파일 삭제 중"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"지우는 중"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"G HUB 제거 중 오류가 발생했습니다: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" 컴퓨터를 리부팅하여 제거 프로그램을 다시 실행하세요."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"레지스트리 키를 삭제하지 못했습니다."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"일부 폴더를 삭제하지 못했습니다."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"일부 파일을 삭제하지 못했습니다."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"G HUB 서비스를 제거하지 못했습니다."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"G HUB 절차를 중단하지 못했습니다."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"알 수 없는 오류(코드 {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"제거"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"제거하면 시스템에서 G HUB가 제거됩니다. 계속 진행하시겠습니까? 이 작업은 돌이킬 수 없습니다."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech G HUB 설치 프로그램"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech G HUB 설치 응용프로그램"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"설치"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"끝내기"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"이 소프트웨어는 시스템에 이미 존재합니다. G HUB를 실행하여 업데이트를 확인하세요."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"시스템의 Logitech 게임 소프트웨어는 호환이 안 되는 옛 버전입니다. 업그레이드하거나 제거한 후 G HUB를 설치하십시오."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"LOGITECH G HUB 다운로드 중"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"새로운 Logitech G HUB 소프트웨어는 게임과 장치 구성 경험을 개선하려고 합니다…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…구성 및 보호…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…소사 및 부스팅…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"….호버링 및 착륙…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"다운로드 성공"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"잠금 및 로드 완료."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"설치 및 실행"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"정보"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"종료"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"창 닫기"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"남음"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"설치 중 오류가 발생했습니다."
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"다운로드할 수 없음:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"유효한 업데이트 요약을 가져올 수 없습니다."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"다운로드할 수 없음: 초기화 실패. 인터넷 연결을 확인하고 다시 시도하십시오."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"인터넷 연결을 확인하십시오."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"디스크가 꽉 찬 것 같습니다."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"설치 프로그램의 필수 구성요소를 로드할 수 없습니다. 공식 웹사이트에서 다시 다운로드하세요."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"%d 후 다시 시도하는 중입니다."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"파일 추출"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x0400008A RID: 138
	private static Dictionary<STRING, string> _dict_nb_NO = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"PRØV PÅ NYTT"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"FORTSETT"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"AVBRYT"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"BAKSIDE"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"INSTALLER PÅ NYTT"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"START"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"AVINSTALLER"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"LA PARTYET STARTE"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"AVSLUTT"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"START PÅ NYTT NÅ"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"START PÅ NYTT SENERE"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"ONLINE HJELP"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0} GB ledig på {1}-stasjonen"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Mindre enn 1 GB ledig på {0}-stasjonen"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Mindre enn 500 MB ledig på {0}-stasjonen"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Initialisering av nedlastning mislyktes på grunn av nettverksproblemer. Prøv på nytt."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Nedlastning mislyktes på grunn av nettverksproblemer. Prøv på nytt."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Kan ikke hente gyldig oppdateringssammendrag. Prøv på nytt."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Ikke nok ledig harddiskplass"
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Det oppstod en feil under installasjonen. Prøv på nytt."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Kan ikke pakke ut installasjonsprogramressurser. Problemet kan bli løst ved å starte installasjonsprogrammet på nytt."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Viktige komponenter i installasjonsprogrammet kunne ikke lastes."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Kan ikke starte installering. Problemet kan bli løst ved å lukke og starte installasjonsprogrammet på nytt."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Last det ned på nytt fra "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB er ikke kompatibel med operativsystemet ditt. Sjekk G HUB OS-kompatibilitet for å finne ut mer."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"OFFISIELL NETTSIDE."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSJON {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Installerer i {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB av {1} MB ({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Vi oppdager lave nedlastingshastigheter"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Haster det? Vi holder på med kalibreringer"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Vi kontrollerer at skriveren og din inkognito-historikk er riktig tilkoblet"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Omdirigerer reaktorkraft"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Innkaller en Nyan cat"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Du trenger mer vespene-gass"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Jeg gjør ikke noe mistenkelig. Virkelig!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Tessellerer evighetsmatrisen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Du må konstruere flere pyloner"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"Vitamin D er viktig for kroppen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Frame Shift Drive aktivert"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Det er bedre med én mus i hånden enn to i buskaset"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Tiden flyr når man har det gøy"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Får noe ut av systemet"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Dette vil også gå over"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Ta på seg buksene"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Sender ut vår beste kriger"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan ser mistenkelig ut ..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Retikulerer splinter"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Iverksetter plan for verdensherredømme"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Hva gjør denne knappen?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hei, du! Du er endelig våken"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Datamaskinen må startes på nytt for å fullføre installeringskravene. Installeringsprogrammet åpnes på nytt når datamaskinen er startet på nytt."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Installasjonen mislyktes."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Initialiseringen mislyktes."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Allerede installert."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Installere G HUB på nytt?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Avinstallerer."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Avinstallering utført."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Feil ved avinstalleringen."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Avslutt installasjon."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Datamaskinen på startes på nytt."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Er du sikker på at du vil avslutte?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Initialiserer"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Pakker ut"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Installerer"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Fullfører"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Når du klikker på Installer, godtar du vilkårene i "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"LISENSAVTALE FOR SLUTTBRUKERE."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Vent mens vi installerer G HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB er installert og ser ut til å fungere slik den skal."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Start G HUB for å se etter oppdateringer"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Installer G HUB på nytt"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Programvaren er allerede installert på systemet, men virker skadet. Installering på nytt kan løse det."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Først vil eksisterende G HUB-programvaren bli avinstallert. Denne operasjonen kan ikke avbrytes eller angres."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB har blitt avinstallert fra systemet."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Vent mens vi avinstallerer G HUB. Denne operasjonen kan ta litt tid."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Forrige installasjon av G HUB har blitt fjernet. Du kan fortsette med en ny installasjon."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Overfør mine gjeldende innstillinger"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB avinstalleringsprogram"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Kritiske komponenter mangler: Installer Microsoft Visual C++ Redistributable 2019 på nytt eller last ned og bruk G HUB installeringsprogram fra støttesiden."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Vent mens vi avinstallerer G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Fjerner programvarekomponenter"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Sletter gjenværende filer"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Rensker opp"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Det oppsto en feil ved avinstallering av G HUB: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Forsøk å starte datamaskinen på nytt og avinstallere igjen."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Kan ikke fjerne registernøkler."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Kan ikke slette visse mapper."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Kan ikke slette visse filer."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Kan ikke fjerne G HUB service."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Kan ikke stanse G HUB-prosesser."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Ukjent feil (kode {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Avinstaller"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Avinstallering vil fjerne G HUB fra systemet. Er du sikker på at du vil fortsette? Denne operasjonen kan ikke angres."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Installasjonsprogram for Logitech G HUB"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Installasjonsapp for Logitech G HUB"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALLER"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"AVSLUTT"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Denne programvaren finnes allerede i systemet. Start G HUB for å se etter oppdateringer."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"En utdatert og inkompatibel versjon av Logitech Gaming Software finnes på systemet. Oppgrader eller fjern denne versjonen for å installere G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"LASTER NED LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Den nye Logitech G HUB-programvaren er i ferd med å forbedre konfigurasjonsopplevelsen for spill og enheter …"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…\u00a0bygger og beskytter\u00a0…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"… skyting og styrking …"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…\u00a0svever og lander\u00a0…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"NEDLASTET"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Låst og ladd."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALLER OG LANSER"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Om"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Avslutt"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Lukk vinduet"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"gjenstående"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Det oppstod en feil under installasjonen"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Kan ikke laste ned:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Kan ikke hente et gyldig oppdateringssammendrag."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Kan ikke laste ned: Initialiseringen mislyktes. Kontroller Internett-tilkoblingen og prøv på nytt."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Kontroller Internett-tilkoblingen."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Disken er full."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Viktige komponenter i installasjonsprogrammet kunne ikke lastes. Last ned installasjonsprogrammet på nytt fra det offisielle nettstedet."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Prøver på nytt om %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Pakk ut filer"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x0400008B RID: 139
	private static Dictionary<STRING, string> _dict_nl_NL = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G\u00a0HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"OPNIEUW PROBEREN"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"DOORGAAN"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"ANNULEREN"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"ACHTERKANT"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"OPNIEUW INSTALLEREN"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"STARTEN"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"VERWIJDEREN"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"LATEN WE FEESTEN"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"AFSLUITEN"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"NU OPNIEUW OPSTARTEN"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"LATER OPNIEUW OPSTARTEN"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"ONLINE HULP"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0} GB momenteel beschikbaar op {1}-station"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Minder dan 1 GB beschikbaar op {0}-station"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Minder dan 500 MB beschikbaar op {0}-station"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Initialisatie van download mislukt vanwege netwerkprobleem. Probeer het opnieuw."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Download mislukt vanwege netwerkprobleem. Probeer het opnieuw."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Kan geen geldig updateoverzicht ophalen. Probeer het opnieuw."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Niet voldoende schijfruimte beschikbaar."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Er is een fout opgetreden tijdens de installatie. Probeer het opnieuw."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Uitpakken van resources voor installatieprogramma is mislukt. Opnieuw starten van het installatieprogramma kan dit probleem verhelpen."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Essentiële onderdelen van het installatieprogramma kunnen niet worden geladen."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Starten van installatie is mislukt. Sluiten en opnieuw starten van het installatieprogramma kan dit probleem verhelpen."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Download het opnieuw via de "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB is niet compatibel met jouw huidige besturingssysteem. Controleer de compatibiliteit van G HUB OS voor meer info."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"OFFICIËLE WEBSITE."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSIE {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Installeren op {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB van {1} MB ({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Lage downloadsnelheid gedetecteerd"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Kan het wachten? Er worden enkele kalibraties uitgevoerd"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Er wordt voor gezorgd dat je printer en je incognito-geschiedenis goed verbonden zijn"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Reactorvermogen omleiden"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Een Nyan Cat oproepen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Je hebt meer vespene nodig"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Ik doe niets verdachts. Echt!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Tessellatie van de oneindige matrix"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Je moet extra pylons maken"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"Vitamine D is essentieel voor het menselijk lichaam"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Frame Shift Drive, ingeschakeld"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Beter één muis in de hand dan tien in de lucht"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"De tijd vliegt als je plezier hebt"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Iets uit je systeem krijgen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Ook dit zal overgaan"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Broek aantrekken"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"We sturen onze beste krijger"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan ziet er verdacht uit..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Coördinaten worden opnieuw ingesteld"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Plan voor wereldheerschappij wordt uitgevoerd"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Waar is deze knop voor?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hé, jij daar. Je bent eindelijk wakker"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Je moet opnieuw opstarten om de installatie van de vereiste componenten te voltooien. Het installatieprogramma wordt opnieuw geopend, zodra de computer opnieuw is opgestart."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Installatie mislukt."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Initialisatie mislukt."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Al geïnstalleerd."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"G HUB opnieuw installeren?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Wordt verwijderd."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Verwijderd."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Fout bij het verwijderen."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Installatie afsluiten."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Opnieuw opstarten vereist."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Weet je zeker dat je wilt afsluiten?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Wordt geïnitialiseerd"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Bestanden worden uitgepakt"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Bezig met installeren"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Wordt voltooid"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Door op Installeren te klikken ga je akkoord met de voorwaarden van de "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"LICENTIEOVEREENKOMST VOOR EINDGEBRUIKERS."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Even geduld. G HUB wordt geïnstalleerd."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB is geïnstalleerd en lijkt goed te werken."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"G HUB starten om naar updates te zoeken"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"G HUB opnieuw installeren"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Deze software is al op dit systeem geïnstalleerd, maar lijkt te zijn beschadigd. Door opnieuw te installeren kan het probleem worden verholpen."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Wanneer je opnieuw installeert, wordt eerst de bestaande G HUB-software verwijderd. Je kunt deze bewerking niet annuleren of ongedaan maken."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB is van het systeem verwijderd."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Even geduld. G HUB wordt verwijderd. Deze bewerking kan enige tijd duren."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"De vorige G HUB-installatie is verwijderd. Je kunt doorgaan met een nieuwe installatie."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Mijn huidige instellingen overdragen"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Verwijderprogramma voor G HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Er ontbreken essentiële componenten: Installeer het te distribueren pakket van Microsoft Visual C++ 2019 opnieuw of download en gebruik het G HUB-installatieprogramma van de ondersteuningssite."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Even geduld. G HUB wordt verwijderd."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Softwarecomponenten verwijderen"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Resterende bestanden verwijderen"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Wordt gereinigd"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Er is een fout opgetreden bij het verwijderen van G HUB: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Start je computer opnieuw op en voer het verwijderingsprogramma opnieuw uit."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Verwijdering van registersleutels is mislukt."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Verwijdering van enkele mappen is mislukt."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Verwijdering van enkele bestanden is mislukt."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Verwijdering van G HUB-service is mislukt."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Stoppen van G HUB-processen is mislukt."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Onbekende fout (code {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Verwijderen"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Door te verwijderen wordt G HUB van je systeem verwijderd. Weet je zeker dat je door wilt gaan? Deze bewerking kan niet ongedaan worden gemaakt."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Installatieprogramma voor Logitech G HUB"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Installatieprogramma voor Logitech G HUB"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALLEREN"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"AFSLUITEN"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Deze software is al aanwezig op het systeem. Start G HUB op om naar updates te zoeken."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"Er staat een verouderde en incompatibele versie van Logitech Gaming Software op het systeem. Upgrade of verwijder deze om G HUB te installeren."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"LOGITECH G HUB DOWNLOADEN"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"De nieuwe Logitech G HUB-software verbetert je game en je apparaatconfiguratie…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…bouwen en beschermen…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…strafen en boosten…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…zweven en landen…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"DOWNLOAD VOLTOOID"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Klaar voor de start."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALLEREN EN STARTEN"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Info"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Afsluiten"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Venster sluiten"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"resterend"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Er is een fout opgetreden tijdens de installatie"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Download mislukt:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Kan geen geldig updateoverzicht ophalen."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Download mislukt: Initialisatie mislukt. Controleer je internetverbinding en probeer het opnieuw."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Controleer je internetverbinding."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Schijf lijkt vol te zijn."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Essentiële onderdelen van het installatieprogramma kunnen niet worden geladen. Download het installatieprogramma opnieuw van de officiële website."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Opnieuw proberen over %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Bestanden uitpakken"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x0400008C RID: 140
	private static Dictionary<STRING, string> _dict_pl_PL = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"SPRÓBUJ PONOWNIE"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"KONTYNUUJ"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"ANULUJ"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"TYŁ"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"ZAINSTALUJ PONOWNIE"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"URUCHOM"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"ODINSTALUJ"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"ZACZNIJMY IMPREZĘ"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"ZAMKNIJ"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"URUCHOM PONOWNIE TERAZ"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"URUCHOM PONOWNIE PÓŹNIEJ"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"POMOC ONLINE"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"Pozostało {0} GB na dysku {1}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Pozostało mniej niż 1 GB na dysku {0}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Pozostało mniej niż 500 MB na dysku {0}"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Uruchomienie pobierania nie powiodło się z uwagi na problem z siecią. Spróbuj ponownie."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Pobieranie nie powiodło się z uwagi na problem z siecią. Spróbuj ponownie."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Nie można uzyskać prawidłowego podsumowania aktualizacji. Spróbuj ponownie."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Zbyt mało wolnego miejsca na dysku."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Podczas instalacji wystąpił błąd. Spróbuj ponownie."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Rozpakowanie zasobów instalatora nie powiodło się. Ponowne uruchomienie instalatora może naprawić tę usterkę."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Nie można było załadować istotnych komponentów instalatora."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Rozpoczęcie instalacji nie powiodło się. Zamknięcie instalatora i uruchomienie go ponownie może naprawić tę usterkę."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Prosimy o ponowne pobranie go z "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB nie jest kompatybilny z Twoim obecnym systemem operacyjnym. Sprawdź kompatybilność os z G HUB, aby dowiedzieć się więcej."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"OFICJALNEJ STRONY INTERNETOWEJ."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"WERSJA {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Instaluję w {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB z {1} MB ({2} MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Wykryliśmy wolną prędkość pobierania"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Czy to może poczekać? Właśnie dokonujemy pewnych kalibracji"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Sprawdzamy, czy Twoja drukarka i historia trybu incognito są dobrze połączone"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Przekierowywanie mocy reaktora"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Wzywanie kota Nyan"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Potrzebujesz więcej gazu wespan"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Nie robię niczego podejrzanego. Słowo!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Teselacja matrycy nieskończoności w toku"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Musisz zbudować dodatkowe pylony"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"Witamina D jest niezbędna dla człowieka"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Uruchomiono napęd Frame Shift Drive"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Lepsza myszka w garści niż szczur w piwnicy"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Czas szybko leci, gdy dobrze się bawisz"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Chyba musisz odreagować"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"To również przeminie"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Zakładanie spodni"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Wysyłanie naszego najlepszego wojownika"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyjan wygląda pode..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Siatkowanie krzywej składanej"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Tworzenie planu dominacji nad światem"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Co robi ten przycisk?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hej, ty. Wreszcie nie śpisz"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Instalacja składników warunkowych wymaga zrestartowania systemu. Po zrestartowaniu komputera instalator wznowi pracę."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Instalacja nie powiodła się."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Uruchomienie nie powiodło się."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Instalacja już istnieje."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Zainstalować ponownie G HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Trwa dezinstalacja."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Dezinstalacja zakończona powodzeniem."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Wystąpił błąd dezinstalacji."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Zakończ instalację."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Wymagany restart."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Czy na pewno chcesz zakończyć?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Uruchamianie"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Rozpakowywanie"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Instalowanie"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Finalizowanie"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Klikając przycisk „Instaluj”, akceptujesz warunki "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"UMOWY LICENCYJNEJ UŻYTKOWNIKA KOŃCOWEGO."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Proszę czekać na zakończenie instalacji G HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB został zainstalowany i wydaje się pracować prawidłowo."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Uruchom G HUB, aby sprawdzić czy dostępne są aktualizacje"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Zainstaluj ponownie G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Na tym systemie już zainstalowano to oprogramowanie, ale wygląda na to że jest uszkodzone. Ponowna instalacja może to naprawić."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Ponowna instalacja najpierw spowoduje odinstalowanie istniejącego oprogramowania G HUB. Tej operacji nie można anulować, ani cofnąć."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"Dezinstalacja G HUB z systemu zakończona powodzeniem."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Proszę czekać na zakończenie dezinstalacji G HUB. Może to potrwać chwilę."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Poprzednia instalacja G HUB została usunięta. Można przejść do nowej instalacji."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Przenieś moje bieżące ustawienia"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Dezinstalator G HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Brakuje kluczowych komponentów: Zainstaluj ponownie pakiet Microsoft Visual C++ Redistributable 2019 lub pobierz instalator G HUB ze strony pomocy technicznej i uruchom go."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Proszę czekać na zakończenie dezinstalacji G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Usuwanie składników oprogramowania"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Usuwanie pozostałych plików"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Porządkowanie"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Podczas dezinstalacji G HUB wystąpił błąd. "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Uruchom ponownie komputer i uruchom dezinstalator ponownie."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Usunięcie kluczy rejestru nie powiodło się."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Usunięcie niektórych folderów nie powiodło się."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Usunięcie niektórych plików nie powiodło się."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Usunięcie usługi G HUB nie powiodło się."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Zatrzymanie procesów G HUB nie powiodło się."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Nieznany błąd (kod {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Odinstaluj"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Odinstalowanie spowoduje usunięcie G HUB z systemu. Czy na pewno chcesz kontynuować? Tej operacji nie można cofnąć."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Instalator Logitech G HUB"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Aplikacja instalatora Logitech G HUB"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALUJ"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"ZAKOŃCZ"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"To oprogramowanie już istnieje w systemie. Uruchom G HUB, aby poszukać dostępnych aktualizacji."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"W systemie jest zainstalowana przestarzała i niekompatybilna wersja oprogramowania Logitech Gaming Software. Uaktualnij ją lub usuń, aby zainstalować oprogramowanie G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"POBIERANIE OPROGRAMOWANIA LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Nowe oprogramowanie Logitech G HUB wkrótce ulepszy Twoje wrażenia związane z graniem i konfiguracją urządzeń…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…budowanie i ochrona…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…strzelanie i przeładowywanie…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"… unoszenie się i lądowanie…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"POBIERANIE POWIODŁO SIĘ"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Zablokowane i załadowane."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"ZAINSTALUJ I URUCHOM"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Informacje"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Zamknij"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Zamknij okno"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"pozostały"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Podczas instalacji wystąpił błąd"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Nie udało się pobrać:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Nie można uzyskać prawidłowego podsumowania aktualizacji."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Nie udało się pobrać: Uruchomienie nie powiodło się. Sprawdź połączenie z Internetem i ponów próbę."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Sprawdź połączenie z Internetem."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Dysk wydaje się być pełny."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Nie można było załadować istotnych komponentów instalatora. Prosimy o ponowne pobranie instalatora z oficjalnej strony internetowej."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Ponowna próba za %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Rozpakowywanie plików"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x0400008D RID: 141
	private static Dictionary<STRING, string> _dict_pt_BR = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"TENTAR NOVAMENTE"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"CONTINUAR"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"CANCELAR"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"TRASEIRA"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"REINSTALAR"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"INICIAR"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"DESINSTALAR"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"QUE COMECE A FESTA"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"SAIR"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"REINICIAR AGORA"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"REINICIAR MAIS TARDE"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"AJUDA ON-LINE"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0} GB disponível atualmente na unidade {1}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Menos de 1 GB disponível na unidade {0}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Menos de 500 GB disponível na unidade {0}"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Falha ao iniciar o download devido a problemas na rede. Tente novamente."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Falha no download devido a problemas na rede. Tente novamente."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Não foi possível obter resumo de atualização válido. Tente novamente."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Espaço disponível no disco rígido não suficiente."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Ocorreu um erro durante a instalação. Tente novamente."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Falha ao extrair os recursos do instalador. Reiniciar o instalador pode corrigir esse problema."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Não foi possível carregar alguns componentes essenciais do instalador."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Falha ao iniciar a instalação. Fechar e reiniciar o instalador pode corrigir esse problema."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Faça novamente o download do instalador no "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"O G HUB não é compatível com seu sistema operacional atual. Para saber mais, verifique a compatibilidade do G HUB com sistemas operacionais."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"SITE OFICIAL."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSÃO {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Instalando em {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB de {1} MB ({2} MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Estamos detectando velocidades lentas de download"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Pode esperar? Estamos no meio de alguns ajustes"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Verificando se a impressora e seu histórico incógnito estão corretamente conectados"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Desviando a potência do reator"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Invocando um Nyan Cat"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Você precisa de mais gás vespeno"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Não estou fazendo nada suspeito. Sério!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Pavimentação da matriz infinita"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Você deve construir mais pilares"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"A vitamina D é necessária para o corpo humano"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Frame Shift Drive, envolvido"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Mais vale um mouse na mão do que dois voando"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"O tempo voa quando você está se divertindo"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Recebendo algo vindo de fora do seu sistema"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Isso também irá passar"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Vestindo as calças"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Enviando nosso melhor guerreiro"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan parece suspeito..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Reticulação de splines"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Promulgação do plano para dominar o mundo"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"O que faz esse botão?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Ei, você. Finalmente você acordou"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"É necessário reiniciar para terminar a instalação dos pré-requisitos. O instalador será reaberto depois que o computador for reiniciado."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Falha na instalação"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Falha na inicialização."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Já instalado."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Reinstalar o G HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Desinstalando."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Desinstalação bem-sucedida."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Erro na desinstalação."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Sair da instalação"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Reinício necessário."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Tem certeza de que deseja sair?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Inicializando"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Extraindo arquivos"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Instalando"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Finalizando"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Ao clicar em Instalar, você concorda com os termos do "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"CONTRATO DE LICENÇA DE USUÁRIO FINAL"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Aguarde enquanto instalamos o G HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"O G HUB está instalado e parece estar funcionando corretamente."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Inicie o G HUB para verificar se há atualizações"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Reinstalar o G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Este software já está instalado nesse sistema, mas parece danificado. Reinstalar pode corrigir isso."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"A reinstalação irá primeiro desinstalar o software G HUB existente. Esta operação não pode ser cancelada nem desfeita."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"O G HUB foi desinstalado com êxito do sistema."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Aguarde enquanto desinstalamos o G HUB. Esta operação pode demorar algum tempo."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"A instalação anterior do G HUB foi removida. Você pode prosseguir com uma nova instalação."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Transferir minhas configurações atuais"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Desinstalador do G HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Estão faltando componentes críticos: Reinstale o Microsoft Visual C++ Redistributable 2019 ou baixe e use o instalador do G HUB no site de suporte."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Aguarde enquanto desinstalamos o G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Removendo componentes de software"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Excluindo arquivos restantes"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Limpeza"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Ocorreu um erro durante a desinstalação do G HUB: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Tente reiniciar o computador e execute o desinstalador novamente."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Falha ao remover as chaves de registro."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Falha ao excluir algumas pastas."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Falha ao excluir alguns arquivos."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Falha ao remover o serviço G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Falha ao interromper processos do G HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Erro desconhecido (código {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Desinstalar"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"A desinstalação removerá o G HUB do sistema. Tem certeza de que deseja continuar? Esta operação não pode ser desfeita."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Instalador do Logitech G HUB"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Aplicativo de instalação do Logitech G HUB"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALAR"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"SAIR"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Este software já existe no sistema. Inicie o G HUB para procurar por atualizações"
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"Há uma versão desatualizada e incompatível do Logitech Gaming Software no sistema. Atualize ou remova-a para instalar o G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"FAZENDO DOWNLOAD DO LOGITECH HUB G"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"O novo software Logitech G HUB está prestes a aprimorar sua experiência de jogo e configuração de dispositivo…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…construindo e protegendo…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…bombardeando e aumentando…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…navegando e atracando…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"DOWNLOAD BEM SUCEDIDO"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Bloqueado e carregado."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALAR E INICIAR"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Sobre"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Sair"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Janela fechada"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"restante"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Ocorreu um erro durante o processo de atualização."
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Não foi possível fazer download:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Não foi possível obter um resumo de atualização válido."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Não foi possível fazer download: Falha na inicialização. Verifique a conexão com a internet e tente novamente."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Verifique a conexão com a internet."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"O disco parece estar cheio."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Não foi possível carregar alguns componentes essenciais do instalador. Faça novamente o download do instalador no site oficial."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Tentando novamente em %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Extração de arquivos"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x0400008E RID: 142
	private static Dictionary<STRING, string> _dict_ru_RU = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G\u00a0HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"ПОВТОРИТЬ ПОПЫТКУ"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"ПРОДОЛЖИТЬ"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"ОТМЕНА"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"ЗАДНЯЯ"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"ПЕРЕУСТАНОВИТЬ"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"ЗАПУСТИТЬ"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"УДАЛИТЬ"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"НАЧНЕМ ВЕЧЕРИНКУ"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"ВЫХОД"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"ПЕРЕЗАГРУЗИТЬ СЕЙЧАС"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"ПЕРЕЗАГРУЗИТЬ ПОЗЖЕ"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"ОНЛАЙН-СПРАВКА"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0}\u00a0ГБ свободно на диске {1}"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"На диске {0} свободно менее 1\u00a0ГБ"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"На диске {0} свободно менее 500\u00a0МБ"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Инициализация загрузки не удалась из-за проблем с сетью. Повторите попытку."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Загрузка не удалась из-за проблем с сетью. Повторите попытку."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Не удалось получить актуальную сводку по обновлению. Повторите попытку."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Недостаточно свободного места на диске."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Во время установки произошла ошибка. Повторите попытку."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Не удалось распаковать ресурсы установщика. Перезапуск установщика может решить эту проблему."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Не удалось загрузить основные компоненты установщика."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Не удалось начать установку. Для устранения проблемы попробуйте закрыть установщик и снова запустить его."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Выполните загрузку повторно с "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"ПО\u00a0G\u00a0HUB не поддерживается текущей операционной системой. Для получения более подробной информации прочтите о совместимости G\u00a0HUB с разными операционными системами."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"ОФИЦИАЛЬНОГО САЙТА."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"ВЕРСИЯ\u00a0{0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Установка в\u00a0{0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0}\u00a0МБ из {1}\u00a0МБ ({2}\u00a0МБ/с)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Обнаружена низкая скорость скачивания"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Может, в другой раз? Выполняем калибровку"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Проверяем подключение принтера к вашей истории режима инкогнито"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Перенаправляем мощность реактора"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Призываем котика из Nyan cat"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Нужно больше веспена"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Ничем подозрительным я тут не занимаюсь. Честно-честно!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Тесселяция матрицы бесконечности"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Нужно больше пилонов"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"Витамин D необходим для человеческого организма"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Гипердвигатель, на старт!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Лучше мышка в руке, чем единорог в небе"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Когда весело, время летит незаметно"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Удаляем кое-что из вашей системы"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"И это пройдет"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Надеваем штаны"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Отправляем сильнейшего из воинов"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Что-то не нравится мне этот голуб..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Ретикуляция сплайнов"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Претворяем в жизнь план мирового господства"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Интересно, а для чего эта кнопка?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Эй, вы там! Проснулись, наконец-то"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Для завершения установки необходимых компонентов требуется перезапуск. Когда компьютер перезапустится, установщик откроется повторно."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Сбой установки."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Сбой инициализации."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Уже установлено."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Переустановить G\u00a0HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Удаление."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Успешно удалено."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Сбой удаления."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Прервать установку."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Требуется перезапуск."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Вы действительно хотите выйти?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Инициализация"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Извлечение файлов"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Установка"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Завершение"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Нажимая кнопку «Установить», вы принимаете условия "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"ЛИЦЕНЗИОННОЕ СОГЛАШЕНИЕ С КОНЕЧНЫМ ПОЛЬЗОВАТЕЛЕМ."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Подождите, пока завершится установка G\u00a0HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"Программа G\u00a0HUB установлена и работает нормально."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Запустите G\u00a0HUB для проверки наличия обновлений"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Переустановка G\u00a0HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Программа уже установлена в системе, но, вероятно, повреждена. Переустановка может решить эту проблему."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"В процессе переустановки программа G\u00a0HUB сначала будет удалена. Эту операцию нельзя будет отменить."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G\u00a0HUB успешно удалена из системы."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Подождите, пока завершится удаление G\u00a0HUB. На это может потребоваться некоторое время."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Предыдущая установленная версия G\u00a0HUB удалена. Можно перейти к новой установке."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Перенести мои текущие настройки"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Программа удаления G\u00a0HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Отсутствуют критически важные компоненты: пожалуйста, переустановите Microsoft Visual C++ Redistributable 2019 либо загрузите установщик G\u00a0HUB с сайта службы поддержки и используйте его."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Подождите, пока завершится удаление G\u00a0HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Удаление компонентов программного обеспечения"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Удаление оставшихся файлов"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Очистка"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"При удалении G\u00a0HUB произошла ошибка: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Попробуйте перезагрузить компьютер и снова запустить программу удаления."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Не удалось удалить ключи реестра."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Не удалось удалить некоторые папки."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Не удалось удалить некоторые файлы."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Не удалось удалить службу G\u00a0HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Не удалось остановить процесс G\u00a0HUB."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Неизвестная ошибка (код\u00a0{0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Удалить"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Программа G\u00a0HUB будет удалена из системы. Вы действительно хотите продолжить? Эту операцию нельзя будет отменить."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Установщик Logitech\u00a0G\u00a0HUB"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Программа установки Logitech\u00a0G\u00a0HUB"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"УСТАНОВИТЬ"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"ВЫХОД"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Это программное обеспечение уже установлено в системе. Запустите G\u00a0HUB для проверки наличия обновлений."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"В системе выявлена устаревшая и не поддерживаемая версия ПО\u00a0Logitech Gaming Software. Удалите ее или обновите до более поздней версии, чтобы установить приложение G\u00a0HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"ЗАГРУЖАЕМ LOGITECH\u00a0G\u00a0HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Новое ПО Logitech G\u00a0HUB сделает Вашу игру интереснее и предоставит Вам новые возможности настройки устройства…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…строительство и защита…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…стрельба и пополнение боеприпасов…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…свободный полет и приземление…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"ЗАГРУЗКА ПРОШЛА УСПЕШНО"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Все готово к бою!"
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"УСТАНОВИТЬ И ЗАПУСТИТЬ"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"О программе"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Выход"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Закрыть окно"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"осталось"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Во время установки произошла ошибка"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Не удается выполнить загрузку:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Не удалось получить актуальную сводку по обновлению."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Не удается выполнить загрузку: Сбой инициализации. Проверьте состояние подключения к Интернету и повторите попытку."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Проверьте состояние подключения к Интернету."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Похоже, на диске нет места."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Не удалось загрузить основные компоненты установщика. Выполните загрузку установщика повторно с официального сайта."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Выполняется повторная попытка через %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Извлечение файлов"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x0400008F RID: 143
	private static Dictionary<STRING, string> _dict_sv_SE = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"FÖRSÖK IGEN"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"FORTSÄTT"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"AVBRYT"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"BAKSIDA"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"OMINSTALLERA"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"STARTA"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"AVINSTALLERA"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"LÅT FESTEN BÖRJA"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"STÄNG"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"STARTA OM NU"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"STARTA OM SENARE"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"DIREKTHJÄLP"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{0}\u00a0GB är för tillfället ledigt på {1}-enheten"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"Mindre än 1\u00a0GB ledigt på {0}-enheten"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"Mindre än 500\u00a0MB ledigt på {0}-enheten"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Initiering av nedladdning misslyckades på grund av nätverksproblem. Försök igen."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Nedladdning misslyckades på grund av nätverksproblem. Försök igen."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Det gick inte att få en giltig uppdateringssammanfattning. Försök igen."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Det finns inte tillräckligt med ledigt hårddiskutrymme."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Ett fel inträffade under installationen. Försök igen."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Det gick inte att packa upp installationsprogrammets resurser. Att starta om installationsprogrammet kan lösa problemet."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Det gick inte att läsa in väsentliga komponenter i installationsprogrammet."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Det gick inte att starta installationen. Att stänga installationsprogrammet och starta om det kan lösa problemet."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Ladda ner det igen från den "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB är inte kompatibel med din nuvarande version av operativsystemet. Kontrollera kompatibiliteten för G HUB och operativsystem för mer information."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"OFFICIELLA WEBBPLATSEN."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"VERSION {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"Installerar i {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB av {1} MB ({2}\u00a0MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Vi upptäcker långsamma nedladdningshastigheter"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Kan det vänta? Vi håller på med några kalibreringar"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Se till att skrivaren och inkognitohistoriken är korrekt anslutna"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Leder om reaktorkraft"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Tillkallar en Nyan-katt"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Du behöver mer vespenegas"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Jag gör inget skumt. Jaså!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Tessellerar oändlighetsmatrisen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Du måste bygga fler pyloner"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"D-vitamin är nödvändigt för människokroppen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Framdrivning via ramväxling aktiverad"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"En mus i handen är bättre än tio i skogen"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Tiden går fort när man har roligt"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Få ut något ur systemet"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Även detta går över"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Sätter på sig byxor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"Skickar ut vår bästa krigare"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan ser skum ut ..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Arrangerar krysskilar i nätmönster"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Spelar upp plan för världsdominans"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Vad händer om man trycker på den här knappen?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hej. Du är äntligen vaken."
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"En omstart krävs för att slutföra installationen av nödvändiga komponenter. Installationsprogrammet öppnas på nytt när datorn har startats om."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Installationen misslyckades."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Initieringen misslyckades."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Redan installerad."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"Ominstallera G HUB?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Avinstallerar."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Avinstallationen är slutförd."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Fel vid avinstallation."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Avsluta installation"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Omstart krävs."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Är du säker på att du vill avsluta?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Initierar"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Packar upp"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Installerar"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Slutför"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"Genom att klicka på ”Installera” godkänner du villkoren i vårt "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"LICENSAVTAL FÖR SLUTANVÄNDARE"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"Vänta medan vi installerar G HUB."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB har installerats och verkar fungera korrekt."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Starta G HUB för att söka efter uppdateringar"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"Ominstallera G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Programvaran är redan installerad på systemet men verkar vara skadad. Att ominstallera den kan lösa problemet."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Om du väljer att ominstallera den kommer den befintliga G HUB-programvaran först att avinstalleras. Åtgärden kan inte avbrytas eller ångras."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB har avinstallerats från systemet."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"Vänta medan vi avinstallerar G HUB. Åtgärden kan ta en stund."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Den tidigare installationen av G HUB har tagits bort. Du kan fortsätta med en ny installation."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Överför mina nuvarande inställningar"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"Avinstallationsprogram för G HUB"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Viktiga komponenter saknas: Återinstallera Microsoft Visual C++ Redistributable 2019 eller ladda ner och använd G HUB-installationsprogrammet från supportwebbplatsen."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"Vänta medan vi avinstallerar G HUB."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Tar bort programvarukomponenter"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Tar bort återstående filer"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Rensar"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"Ett fel inträffade under avinstallationen av G HUB: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Försök starta om datorn och kör avinstallationsprogrammet igen."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Det gick inte att ta bort registernycklar."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Det gick inte ta bort vissa mappar."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Det gick inte att ta bort vissa filer."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"Det gick inte att ta bort G HUB-tjänsten."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"Det gick inte att stoppa G HUB-processer."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Okänt fel (kod {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Avinstallera"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Avinstallation innebär att G HUB tas bort från systemet. Är du säker på att du vill fortsätta? Åtgärden kan inte ångras."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech G HUB installerare"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech G HUB Installationsapp"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"INSTALLERA"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"AVSLUTA"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Programvaran finns redan på systemet. Starta G HUB för att söka efter uppdateringar."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"En utgången och inkompatibel version av Logitech Gaming Software finns på systemet. Uppgradera eller ta bort det för att installera G HUB."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"HÄMTAR LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Den nya Logitech G HUB-programvaran är i färd med att förbättra din spel- och enhetskonfigurationsupplevelse …"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…bygger och skyddar…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…rörelse i sidoläge och boosting …"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"… svävar och landar…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"NEDLADDNING LYCKADES"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Låst och laddad."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"INSTALLERA OCH STARTA"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Om"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Avsluta"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Stäng fönstret"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"återstår"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Ett fel inträffade under installationen"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"Det gick inte att ladda ner:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Det gick inte att få en giltig uppdateringssammanfattning."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"Det gick inte att ladda ner: Initieringen misslyckades. Kontrollera internetanslutningen och försök igen."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Kontrollera internetanslutningen."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Disk verkar vara full."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Det gick inte att läsa in väsentliga komponenter i installationsprogrammet. Ladda ner installationsprogrammet på nytt från den officiella webbplatsen."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"Försöker igen om %d."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Packa upp filer"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000090 RID: 144
	private static Dictionary<STRING, string> _dict_tr_TR = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"TEKRAR DENE"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"DEVAM"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"İPTAL"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"GERİ"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"YENİDEN YÜKLE"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"BAŞLAT"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"KALDIR"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"PARTİ ZAMANI"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"ÇIK"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"ŞİMDİ YENİDEN BAŞLAT"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"DAHA SONRA YENİDEN BAŞLAT"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"ONLINE YARDIM"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{1} sürücüsünde şu anda {0} GB alan var"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"{0} sürücüsünde 1 GB’tan az alan var"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"{0} sürücüsünde 500 MB’tan az alan var"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"Ağ sorunu nedeniyle indirme başlatılamadı. Lütfen yeniden deneyin."
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"Ağ sorunu nedeniyle indirilemedi. Lütfen yeniden deneyin."
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"Geçerli bir güncelleme özeti alınamadı. Lütfen yeniden deneyin."
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"Yeterli sabit disk alanı yok."
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"Yükleme sırasında bir hata oluştu. Lütfen yeniden deneyin."
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"Yükleyici kaynakları çıkarılamadı. Yükleyiciyi yeniden başlatmak bu sorunu düzeltebilir."
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"Yükleyicinin temel bileşenleri yüklenemedi."
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"Yükleme başlatılamadı. Yükleyici kapatıp yeniden başlatmak bu sorunu düzeltebilir."
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"Lütfen yeniden "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB, mevcut işletim sisteminiz ile uyumlu değil. Daha fazla bilgi için lütfen G HUB işletim sistemi uyumluluğunu kontrol edin."
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"RESMİ WEB SİTESİNDEN indirin."
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"SÜRÜM {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"{0} içinde yüklenecek"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB / {1} MB ({2}MB/sn.)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"Yavaş indirme hızı tespit ettik"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"Bekleyebilir mi? Bazı ayarlamalar yapıyoruz"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"Yazıcınızın ve gizli mod geçmişinizin düzgün şekilde bağlandığından emin olun"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"Reaktör gücü yeniden yönlendiriliyor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"Nyan Cat çağrılıyor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"Daha fazla vespene gazı gerekiyor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"Şüpheli bir şey yapmıyorum. Gerçekten!"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"Sonsuzluk matrisi mozaikleniyor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"Ek pylon inşa etmeniz gerekir"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"D vitamini insan vücudu için gereklidir"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"Kare Geçiş Sürücüsü, Devrede"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"Bugünün faresi yarının hamster’ından iyidir"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"Eğlenirken zaman uçup gider"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"Sisteminizden bir şey çıkarılıyor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"Bu da geçer"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"Pantolon giyiliyor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"En iyi savaşçımızı gönderiyoruz"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan şüpheli gör..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"Ağ örülüyor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"Dünya hakimiyeti için plan yürürlüğe alınıyor"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"Bu düğme ne işe yarıyor?"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"Hey, sen. Sonunda uyandın"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"Ön şartları yükleme işlemini tamamlamak için yeniden başlatma gerekir. Bilgisayar yeniden başlatıldığında yükleyici yeniden açılır."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"Yüklenemedi."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"Başlatılamadı."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"Zaten yüklenmiş."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"G HUB yeniden yüklensin mi?"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"Kaldırılıyor."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"Başarıyla kaldırıldı."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"Kaldırma işlemi sırasında hata."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"Yüklemeden Çık."
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"Yeniden başlatma gerekli."
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"Çıkmak istediğinizden emin misiniz?"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"Başlatılıyor"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"Çıkarılıyor"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"Yükleniyor"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"Sonlandırılıyor"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"“Yükle” seçeneğine tıklayarak şuradaki koşulları kabul etmiş olursunuz: "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"SON KULLANICI LİSANS SÖZLEŞMESİ."
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"G HUB yüklenirken lütfen bekleyin."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB yüklendi ve düzgün şekilde çalışıyor."
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"Güncellemeleri kontrol etmek için G HUB’ı başlat"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"G HUB’ı yeniden yükle"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"Bu yazılım, bu sistemde zaten yüklü ancak hasarlı görünüyor. Yeniden yüklemek sorunu düzeltebilir."
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"Yeniden yükleme için öncelikle mevcut G HUB yazılımınız kaldırılır. Bu işlem iptal edilemez veya geri alınamaz."
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB başarıyla sistemden kaldırıldı."
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"G HUB kaldırılırken lütfen bekleyin. Bu işlem biraz zaman alabilir."
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"Önceki G HUB yüklemesi kaldırıldı. Yeni yükleme işlemine geçebilirsiniz."
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"Mevcut ayarlarımı aktar"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB Yükleme Kaldırıcı"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"Önemli bileşenler eksik: Lütfen Microsoft Visual C++ Redistributable 2019’u yeniden yükleyin veya destek sitesinden G HUB yükleyicisini indirip kullanın."
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"G HUB kaldırılırken lütfen bekleyin."
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"Yazılım bileşenleri kaldırılıyor"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"Kalan dosyalar siliniyor"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"Temizleniyor"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"G HUB kaldırılırken bir hata oluştu: "
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" Bilgisayarınızı yeniden başlatmayı deneyin ve yükleme kaldırıcıyı yeniden çalıştırın."
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"Kayıt defteri anahtarları kaldırılamadı."
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"Bazı klasörler silinemedi."
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"Bazı dosyalar silinemedi."
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"G HUB hizmeti kaldırılmadı."
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"G HUB işlemleri durdurulamadı."
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"Bilinmeyen hata (kod {0})."
		},
		{
			STRING.UNINSTALLER_TITLE,
			"Kaldır"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"Kaldırma işlemi, G HUB’ı sisteminizden kaldıracaktır. Devam etmek istediğinizden emin misiniz? Bu işlem geri alınamaz."
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech G HUB Yükleyici"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech G HUB Yükleyici Uygulaması"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"YÜKLE"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"ÇIKIŞ"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"Bu yazılım zaten sistemde yüklü. Güncellemeleri kontrol etmek için G HUB’ı başlatın."
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"Logitech Gaming Software'in güncel olmayan ve uyumsuz bir sürümü sistemde yüklü. Bunu yükseltin veya kaldırıp G HUB'ı yükleyin."
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"LOGITECH G HUB İNDİRİLİYOR"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"Yeni Logitech G HUB yazılımı sayesinde oyun ve cihaz yapılandırması deneyiminiz…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…oluşturuluyor ve korunuyor…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…hızlı ve güçlü bir şekilde artacak…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…imleç üzerine getiriliyor ve duruluyor…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"İNDİRME BAŞARILI OLDU"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"Kilitlendi ve yüklendi."
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"YÜKLE VE BAŞLAT"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"Hakkında"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"Çıkış"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"Pencereyi Kapat"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"kaldı"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"Yükleme sırasında bir hat oluştu"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"İndirilemedi:"
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"Geçerli bir güncelleme özeti alınamadı."
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"İndirilemedi: Başlatılamadı. Lütfen İnternet bağlantınızı kontrol edin ve yeniden deneyin."
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"Lütfen İnternet bağlantınızı kontrol."
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"Disk dolu görünüyor."
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"Yükleyicinin temel bileşenleri yüklenemedi. Lütfen yükleyiciyi resmi web sitesinden tekrar indirin."
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"%d içinde tekrar deneniyor."
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"Dosya çıkarma"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000091 RID: 145
	private static Dictionary<STRING, string> _dict_zh_CN = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"请再试一次"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"继续"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"取消"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"后"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"重新安装"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"启动"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"卸载"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"尽情游戏"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"退出"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"立即重新启动"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"稍后重新启动"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"联机帮助"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"{1}驱动器上目前有 {0} GB 可用"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"{0}驱动器上的可用空间少于 1GB"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"{0}驱动器上的可用空间少于 500MB"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"由于网络问题，下载初始化失败。请重试。"
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"由于网络问题，下载失败。请重试。"
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"无法获取有效的更新摘要。请重试。"
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"可用磁盘空间不足。"
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"安装时发生错误。请重试。"
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"无法解压安装程序资源。重新启动安装程序可能会解决此问题。"
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"无法加载安装程序的基本组件。"
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"无法开始安装。关闭安装程序并重新启动可能会解决此问题。"
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"请重新下载，请访问 "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB 不兼容您当前的操作系统。请检查 G HUB 的操作系统兼容性以了解更多信息。"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"官方网站。"
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"版本 {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"安装在 {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0}MB/{1} MB（{2} MB/s）"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"我们检测到下载速度缓慢"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"要等等吗？我们正在进行一些校准"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"请确保正确连接了打印机和隐身历史记录"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"转移反应堆功率"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"召唤彩虹猫"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"您需要更多的绿色气体"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"我没有做任何可疑的事情。真的！"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"分化无限矩阵"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"您必须构造其他塔"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"维生素 D 是人体必需的"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"空间折叠引擎，启动"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"双鸟在林不如一鸟在手"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"玩得开心，时光飞逝"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"从系统中获取东西"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"这个也行"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"穿上裤子"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"派出我们最好的战士"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"Cyan 看起来..."
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"网状曲线"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"制定世界统治计划"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"此按钮的功能"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"嗨，那谁。你终于醒了"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"需要重新启动才能完成必备组件的安装。重新启动电脑后，安装程序将重新打开。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"安装失败。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"初始化失败。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"已安装。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"重新安装 G HUB？"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"正在卸载。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"卸载成功。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"卸载错误。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"退出安装。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"需要重新启动。"
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"是否确认推出？"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"正在初始化"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"正在解包"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"正在安装"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"正在完成"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"点击“安装”，即代表您已同意 "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"最终用户许可协议"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"安装 G HUB 时，请耐心等待。"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB 已安装，并且看起来运转正常。"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"启动 G HUB 以检查更新"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"重新安装 G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"软件已安装至此系统，但似乎已损坏。重新安装可能会修复问题。"
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"重新安装将首先卸载您当前的 G HUB 软件。此操作无法取消或撤消。"
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB 已成功从系统中卸载。"
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"卸载 G HUB 时，请耐心等待。此操作可能需要一些时间。"
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"此前安装的 G HUB 已删除。您可以继续进行新的安装。"
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"转移我的当前设置"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB 卸载程序"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"缺少关键组件：请重新安装 Microsoft Visual C++ Redistributable 2019 或从支持站点下载并使用 G HUB 安装程序。"
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"卸载 G HUB 时，请耐心等待。"
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"正在移除软件组件"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"删除残留文件"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"清理"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"卸载 G HUB 时发生错误："
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" 尝试重新启动计算机，然后再次运行卸载程序。"
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"无法删除注册表项。"
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"无法删除某些文件夹。"
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"无法删除某些文件。"
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"无法移除 G HUB 服务。"
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"无法停止 G HUB 进程。"
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"未知错误（代码 {0}）。"
		},
		{
			STRING.UNINSTALLER_TITLE,
			"卸载"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"卸载操作将会从您的系统中移除 G HUB。是否继续？此操作无法撤消。"
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech G HUB 安装程序"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech G HUB 安装应用程序"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"安装"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"退出"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"系统已存在本软件。启动 G HUB 以检查更新"
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"系统存在旧版且不兼容的 Logitech 游戏软件版本。请升级或将其移除，以安装 G HUB。"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"下载 LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"全新 Logitech G HUB 软件将大幅改善您的游戏与设备配置体验…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…兴衰荣辱…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…出生入死…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…上天入地…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"下载成功"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"准备完毕。"
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"安装并启动"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"关于"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"退出"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"关闭窗口"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"剩余"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"安装时发生错误"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"无法下载："
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"无法获取有效的更新摘要。"
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"无法下载：初始化失败。请检查互联网连接并重试。"
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"请检查互联网连接。"
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"磁盘已满。"
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"无法加载安装程序的基本组件。请从官方网站重新下载安装程序。"
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"%d 后重试。"
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"文件提取"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000092 RID: 146
	private static Dictionary<STRING, string> _dict_zh_TW = new Dictionary<STRING, string>
	{
		{
			STRING.INSTALLER_APPLICATION_NAME,
			"Logitech G HUB"
		},
		{
			STRING.INSTALLER_GENERIC_TRY_AGAIN,
			"再試一次"
		},
		{
			STRING.INSTALLER_GENERIC_CONTINUE,
			"繼續"
		},
		{
			STRING.INSTALLER_GENERIC_CANCEL,
			"取消"
		},
		{
			STRING.INSTALLER_GENERIC_BACK,
			"背面"
		},
		{
			STRING.INSTALLER_GENERIC_REINSTALL,
			"重新安裝"
		},
		{
			STRING.INSTALLER_GENERIC_LAUNCH_GHUB,
			"啟動"
		},
		{
			STRING.INSTALLER_GENERIC_UNINSTALL,
			"解除安裝"
		},
		{
			STRING.INSTALLER_GENERIC_LETS_PARTY,
			"讓我們開始享受吧"
		},
		{
			STRING.INSTALLER_GENERIC_QUIT,
			"離開"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_NOW,
			"立即重新啟動"
		},
		{
			STRING.INSTALLER_GENERIC_REBOOT_LATER,
			"稍後重新啟動"
		},
		{
			STRING.INSTALLER_ONLINE_HELP,
			"線上說明"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_NORMAL,
			"在 {1} 磁碟機上目前有 {0}GB 可用"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_WARNING,
			"在 {0} 磁碟機上可用空間少於 1GB"
		},
		{
			STRING.INSTALLER_DISK_INDICATOR_ERROR,
			"在 {0} 磁碟機上可用空間少於 500MB"
		},
		{
			STRING.INSTALLER_ERROR_DOWNLOAD_INIT,
			"因為網路問題，下載初始化失敗。請再試一次。"
		},
		{
			STRING.INSTALLER_ERROR_NETWORK_ISSUE,
			"因為網路問題，下載失敗。請再試一次。"
		},
		{
			STRING.INSTALLER_ERROR_UPDATE_SUMMARY,
			"無法獲得有效的更新摘要。請再試一次。"
		},
		{
			STRING.INSTALLER_ERROR_DISK_FULL,
			"沒有足夠的可用磁碟空間。"
		},
		{
			STRING.INSTALLER_ERROR_UNCAUGHT_ERROR,
			"安裝期間發生錯誤。請再試一次。"
		},
		{
			STRING.INSTALLER_ERROR_UNPACKING,
			"無法解壓縮安裝程式資源。重新啟動安裝程式可能可以解決此問題。"
		},
		{
			STRING.INSTALLER_ERROR_DLL_LOADING,
			"無法載入安裝程式的重要元件。"
		},
		{
			STRING.INSTALLER_ERROR_START_INSTALL,
			"無法開始安裝。關閉安裝程式然後再重新啟動，可能可以修正此問題。"
		},
		{
			STRING.INSTALLER_ERROR_REDOWNLOAD,
			"請從 "
		},
		{
			STRING.INSTALLER_ERROR_OS_VERSION,
			"G HUB 不相容於您目前的作業系統。請查看 G HUB 作業系統相容性以瞭解更多資訊。"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE,
			"官方網站重新下載。"
		},
		{
			STRING.INSTALLER_INFO_VERSION,
			"版本 {0}"
		},
		{
			STRING.INSTALLER_INFO_DESTINATION,
			"安裝到 {0}"
		},
		{
			STRING.INSTALLER_INFO_DOWNLOAD_PROGRESS,
			"{0} MB，共 {1} MB ({2}MB/s)"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_0,
			"我們發現下載速度緩慢"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_1,
			"可以再多等待一段時間嗎？我們正在進行某些校正工作"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_2,
			"請確認已正確連接您的印表機和隱身歷史記錄"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_3,
			"分流反應器功率"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_4,
			"召喚 Nyan 貓"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_5,
			"您需要更多高能氣體"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_6,
			"我沒有做任何可疑的事情。真的！"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_7,
			"細分無線矩陣"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_8,
			"你必須建造更多鐵塔"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_9,
			"人體需要維他命 D"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_10,
			"空間折疊引擎，啟動"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_11,
			"一鼠在手好於二鼠在林"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_12,
			"歡樂時光快速飛逝"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_13,
			"好好利用您的系統"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_14,
			"這也會過去"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_15,
			"穿上褲子"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_16,
			"派出我們最好的戰士"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_17,
			"青色看起來…"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_18,
			"網狀樣條"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_19,
			"制定統治世界的計畫"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_20,
			"這個按鈕有什麼作用？"
		},
		{
			STRING.INSTALLER_LOADING_MESSAGE_21,
			"嗨，你。您終於醒來"
		},
		{
			STRING.INSTALLER_MODAL_REBOOT,
			"需要重新啟動才能完成必要組件的安裝。安裝程式會在電腦重新啟動後重新開啟。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_FAILED,
			"安裝失敗。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_INIT_FAILED,
			"初始化失敗。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXITING_SW,
			"已經安裝。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_CONFIRM,
			"重新安裝 G HUB？"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL,
			"解除安裝。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_SUCCESS,
			"解除安裝成功。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_UNINSTALL_FAILURE,
			"解除安裝時發生錯誤。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_EXIT,
			"離開安裝。"
		},
		{
			STRING.INSTALLER_MODAL_TITLE_REBOOT,
			"需要重新啟動。"
		},
		{
			STRING.INSTALLER_MODAL_CONFIRM_EXIT,
			"您確定要離開嗎？"
		},
		{
			STRING.INSTALLER_OFFICIAL_WEBSITE_LINK,
			"https://www.logitechg.com/ghub"
		},
		{
			STRING.INSTALLER_STEP_INITIALIZE,
			"初始化中"
		},
		{
			STRING.INSTALLER_STEP_UNPACK,
			"解壓縮中"
		},
		{
			STRING.INSTALLER_STEP_INSTALLING,
			"安裝中"
		},
		{
			STRING.INSTALLER_STEP_FINALIZING,
			"結束中"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_TEXT,
			"按下「安裝」即表示您同意 "
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK_TEXT,
			"一般使用者授權協議條款。"
		},
		{
			STRING.INSTALLER_TERMS_OF_SERVICE_AGREEMENT_LINK,
			"https://www.logitech.com/legal/eula.html"
		},
		{
			STRING.INSTALLER_TOOLTIP_INSTALL,
			"請稍待片刻，我們正在安裝 G HUB。"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED,
			"G HUB 已安裝且能正確運作。"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_LAUNCH,
			"啟動 G HUB 以檢查更新"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_OPTION_REINSTALL,
			"重新安裝 G HUB"
		},
		{
			STRING.UNINSTALLER_ALREADY_INSTALLED_BAD,
			"此軟體已安裝在您系統上，但似乎已經受損。重新安裝可能可以修復軟體。"
		},
		{
			STRING.UNINSTALLER_MODAL_DESCRIPTION,
			"重新安裝會先解除安裝您現有的 G HUB 軟體。此操作不能取消或復原。"
		},
		{
			STRING.UNINSTALLER_MODEL_DESCRIPTION_BYE,
			"G HUB 已成功從您的系統解除安裝。"
		},
		{
			STRING.UNINSTALLER_MODAL_UNINSTALLING,
			"請稍待片刻，我們正在解除安裝 G HUB。此操作可能要花一點時間。"
		},
		{
			STRING.UNINSTALLER_MODAL_SUCCESS,
			"已經移除之前的 G HUB 安裝。您可繼續進行全新安裝。"
		},
		{
			STRING.UNINSTALLER_MODAL_SETTINGS,
			"傳送我目前的設定"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_TITLE,
			"G HUB 解除安裝程式"
		},
		{
			STRING.UNINSTALLER_MESSAGEBOX_REDIST_MESSAGE,
			"缺少關鍵組件：請重新安裝 Microsoft Visual C++ Redistributable 2019 或是從支援網站下載並使用 G HUB 安裝程式。"
		},
		{
			STRING.UNINSTALLER_STATE_TOOLTIP,
			"請稍待片刻，我們正在解除安裝 G HUB。"
		},
		{
			STRING.UNINSTALLER_STEP_UNINSTALLING,
			"正在移除軟體元件"
		},
		{
			STRING.UNINSTALLER_STEP_RM_FILES,
			"正在刪除剩餘的檔案"
		},
		{
			STRING.UNINSTALLER_STEP_RM_EXTRA_FILES,
			"正在清理"
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P1,
			"解除安裝 G HUB 時發生錯誤："
		},
		{
			STRING.UNINSTALLER_ERROR_DESCRIPTION_P2,
			" 請嘗試重新啟動電腦，然後再次執行解除安裝程式。"
		},
		{
			STRING.UNINSTALLER_ERROR_PRODUCT_REMOVAL,
			"無法移除登錄機碼。"
		},
		{
			STRING.UNINSTALLER_ERROR_FOLDER_DELETION,
			"無法刪除某些資料夾。"
		},
		{
			STRING.UNINSTALLER_ERROR_FILE_DELETION,
			"無法刪除某些檔案。"
		},
		{
			STRING.UNINSTALLER_ERROR_SERVICE_REMOVAL,
			"無法移除 G HUB 服務。"
		},
		{
			STRING.UNINSTALLER_ERROR_PROCESS_KILL,
			"無法停止 G HUB 處理程序。"
		},
		{
			STRING.UNINSTALLER_ERROR_UNKNOWN,
			"不明錯誤 (代碼 {0})。"
		},
		{
			STRING.UNINSTALLER_TITLE,
			"解除安裝"
		},
		{
			STRING.UNINSTALLER_DESCRIPTION,
			"解除安裝程序會從您的系統移除 G HUB。您確定要繼續嗎？此操作不能復原。"
		},
		{
			STRING.INSTALLER_APPLICATION_TITLE,
			"Logitech G HUB 安裝程式"
		},
		{
			STRING.INSTALLER_APPLICATION_DESCRIPTION,
			"Logitech G HUB 安裝程式應用程式"
		},
		{
			STRING.INSTALLER_INSTALL_BUTTON,
			"安裝"
		},
		{
			STRING.INSTALLER_EXIT_BUTTON,
			"退出"
		},
		{
			STRING.INSTALLER_DESCRIPTION_ALREADY_INSTALLED,
			"系統上已存在此軟體。啟動 G HUB 以尋找更新。"
		},
		{
			STRING.INSTALLER_DESCRIPTION_LEGACY_INSTALLED,
			"系統上有過期且不相容的 Logitech 遊戲軟體版本。請將其升級或移除以安裝 G HUB。"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADING,
			"正在下載 LOGITECH G HUB"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING,
			"此新的 Logitech G HUB 軟體可增強您的遊戲與裝置設定體驗…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_1,
			"…建立與保護…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_2,
			"…掃射與提升…"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADING_3,
			"…懸停與泊靠…"
		},
		{
			STRING.INSTALLER_HEADER_DOWNLOADED,
			"下載成功"
		},
		{
			STRING.INSTALLER_DESCRIPTION_DOWNLOADED,
			"已鎖定並已載入。"
		},
		{
			STRING.INSTALLER_INSTALL_AND_LAUNCH_BUTTON,
			"安裝與啟動"
		},
		{
			STRING.INSTALLER_MENU_ABOUT,
			"關於"
		},
		{
			STRING.INSTALLER_MENU_QUIT,
			"退出"
		},
		{
			STRING.INSTALLER_MENU_CLOSE,
			"關閉視窗"
		},
		{
			STRING.INSTALLER_TRANSFER_REMAINING,
			"剩餘"
		},
		{
			STRING.INSTALLER_ERROR_GENERIC,
			"安裝期間發生錯誤"
		},
		{
			STRING.INSTALLER_FAILURE_PREFIX,
			"無法下載："
		},
		{
			STRING.INSTALLER_ERROR_SUMMARY,
			"無法獲得有效的更新摘要。"
		},
		{
			STRING.INSTALLER_ERROR_INITIALIZE,
			"無法下載：初始化失敗。請檢查您的網際網路連線然後再試一次。"
		},
		{
			STRING.INSTALLER_ERROR_TIMEOUT,
			"請檢查您的網際網路連線。"
		},
		{
			STRING.INSTALLER_ERROR_WRITE,
			"磁碟似乎已滿。"
		},
		{
			STRING.INSTALLER_ERROR_DLL,
			"無法載入安裝程式的重要元件。請從官方網站重新下載安裝程式。"
		},
		{
			STRING.INSTALLER_RETRY_COUNTDOWN,
			"在 %d 後重試。"
		},
		{
			STRING.INSTALLER_UNCOMPRESSING,
			"文件提取"
		},
		{
			STRING.INSTALLER_VERSION,
			"2021.10"
		}
	};

	// Token: 0x04000093 RID: 147
	private static Dictionary<string, Dictionary<STRING, string>> _dict = new Dictionary<string, Dictionary<STRING, string>>
	{
		{
			"cs-CZ",
			Strings._dict_cs_CZ
		},
		{
			"cs",
			Strings._dict_cs_CZ
		},
		{
			"da-DK",
			Strings._dict_da_DK
		},
		{
			"da",
			Strings._dict_da_DK
		},
		{
			"de-DE",
			Strings._dict_de_DE
		},
		{
			"de",
			Strings._dict_de_DE
		},
		{
			"en-US",
			Strings._dict_en_US
		},
		{
			"en",
			Strings._dict_en_US
		},
		{
			"es-ES",
			Strings._dict_es_ES
		},
		{
			"es",
			Strings._dict_es_ES
		},
		{
			"fi-FI",
			Strings._dict_fi_FI
		},
		{
			"fi",
			Strings._dict_fi_FI
		},
		{
			"fr-FR",
			Strings._dict_fr_FR
		},
		{
			"fr",
			Strings._dict_fr_FR
		},
		{
			"hu-HU",
			Strings._dict_hu_HU
		},
		{
			"hu",
			Strings._dict_hu_HU
		},
		{
			"it-IT",
			Strings._dict_it_IT
		},
		{
			"it",
			Strings._dict_it_IT
		},
		{
			"ja-JP",
			Strings._dict_ja_JP
		},
		{
			"ja",
			Strings._dict_ja_JP
		},
		{
			"ko-KR",
			Strings._dict_ko_KR
		},
		{
			"ko",
			Strings._dict_ko_KR
		},
		{
			"nb-NO",
			Strings._dict_nb_NO
		},
		{
			"nb",
			Strings._dict_nb_NO
		},
		{
			"nl-NL",
			Strings._dict_nl_NL
		},
		{
			"nl",
			Strings._dict_nl_NL
		},
		{
			"pl-PL",
			Strings._dict_pl_PL
		},
		{
			"pl",
			Strings._dict_pl_PL
		},
		{
			"pt-BR",
			Strings._dict_pt_BR
		},
		{
			"pt",
			Strings._dict_pt_BR
		},
		{
			"ru-RU",
			Strings._dict_ru_RU
		},
		{
			"ru",
			Strings._dict_ru_RU
		},
		{
			"sv-SE",
			Strings._dict_sv_SE
		},
		{
			"sv",
			Strings._dict_sv_SE
		},
		{
			"tr-TR",
			Strings._dict_tr_TR
		},
		{
			"tr",
			Strings._dict_tr_TR
		},
		{
			"zh-CN",
			Strings._dict_zh_CN
		},
		{
			"zh",
			Strings._dict_zh_CN
		},
		{
			"zh-TW",
			Strings._dict_zh_TW
		}
	};
}
