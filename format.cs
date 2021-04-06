
public class CommunityIndex
{
    public List<CommunityPlaceableElement> Tiles = new List<CommunityPlaceableElement>();
    public List<CommunityPlaceableElement> Props = new List<CommunityPlaceableElement>();
    public List<CommunityCreatureElement> Creatures = new List<CommunityCreatureElement>();
    public List<CommunityMusicElement> Music = new List<CommunityMusicElement>();
    public List<CommunityIconAtlasElement> IconsAtlases = new List<CommunityIconAtlasElement>();
}

// {
//     "Tiles": [ ... ],
//     "Props": [ ... ],
//     "Creatures": [ ... ],
//     "Music": [ ... ],
//     "IconsAtlases": [ ... ]
// }

public class CommunityAssetElement
{
    public string Id;
    public string Name;
    public bool IsDeprecated;
    public string GroupTag;
    public string[] Tags;
}

// {
//     "Id": "32cfd208-c363-4434-b817-8ba59faeed17",
//     "Name": "Castle Floor 1",
//     "IsDeprecated": false,
//     "GroupTag": "floor",
//     "Tags": [ "tag0", "tag1", ... ]
// }

public class CommunityPlaceableElement : CommunityAssetElement
{
    public CommunityAssetLoaderData[] Assets;
    public bool IsInteractable;
    public Bounds ColliderBoundsBound;
    public CommunityIconElement Icon;
}

// {
//     ...
//     "Assets": [ ... ]
//     "IsInteractable": false,
//     "ColliderBoundsBound": {
//         "m_Center": { "x": 0.5, "y": 0.25, "z": 0.5 },
//         "m_Extent": { "x": 0.5, "y": 0.25, "z": 0.5 }
//     },
//     "Icon": { ... }
// }

public class CommunityCreatureElement : CommunityAssetElement
{
    public CommunityAssetLoaderData MiniAsset;
    public CommunityAssetLoaderData BaseAsset;
    public float DefaultScale;
}

// {
//     ...
//     "MiniAsset": { ... },
//     "BaseAsset": { ... },
//     "DefaultScale": 1.0
// }

public class CommunityMusicElement : CommunityAssetElement
{
    public CommunityLoaderData Asset;
}

// {
//     ...
//     "CommunityLoaderData": { ... }
// }

public class CommunityAssetLoaderData
{
    public CommunityLoaderData LoaderData;
    public Vector3 Position;
    public Quaternion Rotation;
    public Vector3 Scale;
}
// {
//     "LoaderData": { ... },
//     "Position": { "x": 0.1, "y": 0.1, "z": 0.1 },
//     "Rotation": { "x": 0, "y": 0, "z": 0, "w": 1 },
//     "Scale": { "x": 0.3, "y": 0.3, "z": 0.3 }
// }

public class CommunityLoaderData
{
    public string BundleId;
    public string AssetName;
}

//  {
//     "BundleId": "char_camel_01_1606089934",
//     "AssetName": "Camel01"
//  }

public class CommunityIconElement
{
    public int AtlasIndex;
    public Rect Region; 
}

// note: the index is the index into the IconsAtlases info
// note: the region values are normalized with respect to the size of the image
//
// {
//     "AtlasIndex": 2,
//     "Region": {
//         "x": 0.125,
//         "y": 0.9375,
//         "width": 0.0625,
//         "height": 0.0625
//     }
// }

public class CommunityIconAtlasElement
{
    public string Path;
}

// {
//     "Path": "aTVvbnNj"
// }
