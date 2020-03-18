using System.Collections.Generic;

namespace InstagramData
{
    public class PageInfo
    {
        public bool has_next_page { get; set; }
        public string end_cursor { get; set; }
    }

    public class EdgeMediaToCaption
    {
        public IList<Edge> edges { get; set; }
    }

    public class EdgeMediaToComment
    {
        public int count { get; set; }
    }

    public class Dimensions
    {
        public int height { get; set; }
        public int width { get; set; }
    }

    public class EdgeLikedBy
    {
        public int count { get; set; }
    }

    public class ThumbnailResource
    {
        public string src { get; set; }
        public int config_width { get; set; }
        public int config_height { get; set; }
    }

    public class Node
    {
        public string username { get; set; }

        public string text { get; set; }

        public bool comments_disabled { get; set; }
        public string __typename { get; set; }
        public string id { get; set; }
        public EdgeMediaToCaption edge_media_to_caption { get; set; }
        public string shortcode { get; set; }
        public EdgeMediaToComment edge_media_to_comment { get; set; }
        public int taken_at_timestamp { get; set; }
        public Dimensions dimensions { get; set; }
        public string display_url { get; set; }
        public EdgeLikedBy edge_liked_by { get; set; }
        public EdgeMediaPreviewLike edge_media_preview_like { get; set; }
        public Owner owner { get; set; }
        public string thumbnail_src { get; set; }
        public IList<ThumbnailResource> thumbnail_resources { get; set; }
        public bool is_video { get; set; }
        public string accessibility_caption { get; set; }
        public string product_type { get; set; }
        public int? video_view_count { get; set; }
    }

    public class Edge
    {
        public Node node { get; set; }
    }

    public class EdgeHashtagToMedia
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public IList<Edge> edges { get; set; }
    }

    public class EdgeHashtagToTopPosts
    {
        public IList<Edge> edges { get; set; }
    }

    public class EdgeHashtagToContentAdvisory
    {
        public int count { get; set; }
        public IList<object> edges { get; set; }
    }

    public class EdgeHashtagToRelatedTags
    {
        public IList<object> edges { get; set; }
    }

    public class EdgeHashtagToNullState
    {
        public IList<object> edges { get; set; }
    }

    public class Hashtag
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool allow_following { get; set; }
        public string description { get; set; }
        public bool is_following { get; set; }
        public bool is_top_media_only { get; set; }
        public string profile_pic_url { get; set; }
        public EdgeHashtagToMedia edge_hashtag_to_media { get; set; }
        public EdgeHashtagToTopPosts edge_hashtag_to_top_posts { get; set; }
        public EdgeHashtagToContentAdvisory edge_hashtag_to_content_advisory { get; set; }
        public EdgeHashtagToRelatedTags edge_hashtag_to_related_tags { get; set; }
        public EdgeHashtagToNullState edge_hashtag_to_null_state { get; set; }
    }

    public class Graphql
    {
        public User user { get; set; }

        public Hashtag hashtag { get; set; }

        public ShortcodeMedia shortcode_media { get; set; }
    }

    public class EdgeFollowedBy
    {
        public int count { get; set; }
    }

    public class EdgeFollow
    {
        public int count { get; set; }
    }

    public class EdgeMutualFollowedBy
    {
        public int count { get; set; }
        public IList<Edge> edges { get; set; }
    }

    public class EdgeFelixVideoTimeline
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public IList<object> edges { get; set; }
    }

    public class EdgeOwnerToTimelineMedia
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public IList<Edge> edges { get; set; }
    }

    public class EdgeSavedMedia
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }

        public IList<Edge> edges { get; set; }
    }

    public class EdgeMediaCollections
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }

        public IList<Edge> edges { get; set; }
    }

    public class User
    {
        public string biography { get; set; }
        public bool blocked_by_viewer { get; set; }
        public bool restricted_by_viewer { get; set; }
        public bool country_block { get; set; }
        public string external_url { get; set; }
        public string external_url_linkshimmed { get; set; }
        public EdgeFollowedBy edge_followed_by { get; set; }
        public bool followed_by_viewer { get; set; }
        public EdgeFollow edge_follow { get; set; }
        public bool follows_viewer { get; set; }
        public string full_name { get; set; }
        public bool has_ar_effects { get; set; }
        public bool has_channel { get; set; }
        public bool has_blocked_viewer { get; set; }
        public int highlight_reel_count { get; set; }
        public bool has_requested_viewer { get; set; }
        public string id { get; set; }
        public bool is_business_account { get; set; }
        public bool is_joined_recently { get; set; }
        public object business_category_name { get; set; }
        public string category_id { get; set; }
        public object overall_category_name { get; set; }
        public bool is_private { get; set; }
        public bool is_verified { get; set; }
        public EdgeMutualFollowedBy edge_mutual_followed_by { get; set; }
        public string profile_pic_url { get; set; }
        public string profile_pic_url_hd { get; set; }
        public bool requested_by_viewer { get; set; }
        public string username { get; set; }
        public object connected_fb_page { get; set; }
        public EdgeFelixVideoTimeline edge_felix_video_timeline { get; set; }
        public EdgeOwnerToTimelineMedia edge_owner_to_timeline_media { get; set; }
        public EdgeSavedMedia edge_saved_media { get; set; }
        public EdgeMediaCollections edge_media_collections { get; set; }
    }

    public class InstagramData
    {
        /// <summary>
        /// Parameter used to take json response of any url of instagram (__a=1)
        /// </summary>
        public const string __a = "1";

        public string logging_page_id { get; set; }
        public bool show_suggested_profiles { get; set; }
        public bool show_follow_dialog { get; set; }
        public Graphql graphql { get; set; }
        public object toast_content_on_load { get; set; }
    }

    public class DisplayResource
    {
        public string src { get; set; }
        public int config_width { get; set; }
        public int config_height { get; set; }
    }

    public class EdgeMediaToTaggedUser
    {
        public IList<object> edges { get; set; }
    }

    public class EdgeMediaToParentComment
    {
        public int count { get; set; }
        public PageInfo page_info { get; set; }
        public IList<Edge> edges { get; set; }
    }

    public class EdgeMediaToHoistedComment
    {
        public IList<object> edges { get; set; }
    }

    public class EdgeMediaPreviewComment
    {
        public int count { get; set; }
        public IList<Edge> edges { get; set; }
    }

    public class EdgeMediaPreviewLike
    {
        public int count { get; set; }
        public IList<Edge> edges { get; set; }
    }

    public class EdgeMediaToSponsorUser
    {
        public IList<object> edges { get; set; }
    }

    public class Location
    {
        public string id { get; set; }
        public bool has_public_page { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string address_json { get; set; }
    }

    public class Owner
    {
        public string id { get; set; }
        public bool is_verified { get; set; }
        public string profile_pic_url { get; set; }
        public string username { get; set; }
        public bool blocked_by_viewer { get; set; }
        public bool restricted_by_viewer { get; set; }
        public bool followed_by_viewer { get; set; }
        public string full_name { get; set; }
        public bool has_blocked_viewer { get; set; }
        public bool is_private { get; set; }
        public bool is_unpublished { get; set; }
        public bool requested_by_viewer { get; set; }
        public EdgeOwnerToTimelineMedia edge_owner_to_timeline_media { get; set; }
    }

    public class EdgeWebMediaToRelatedMedia
    {
        public IList<object> edges { get; set; }
    }

    public class ShortcodeMedia
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public string shortcode { get; set; }
        public Dimensions dimensions { get; set; }
        public object gating_info { get; set; }
        public object fact_check_overall_rating { get; set; }
        public object fact_check_information { get; set; }
        public string media_preview { get; set; }
        public string display_url { get; set; }
        public IList<DisplayResource> display_resources { get; set; }
        public string accessibility_caption { get; set; }
        public bool is_video { get; set; }
        public string tracking_token { get; set; }
        public EdgeMediaToTaggedUser edge_media_to_tagged_user { get; set; }
        public EdgeMediaToCaption edge_media_to_caption { get; set; }
        public bool caption_is_edited { get; set; }
        public bool has_ranked_comments { get; set; }
        public EdgeMediaToParentComment edge_media_to_parent_comment { get; set; }
        public EdgeMediaToHoistedComment edge_media_to_hoisted_comment { get; set; }
        public EdgeMediaPreviewComment edge_media_preview_comment { get; set; }
        public bool comments_disabled { get; set; }
        public bool commenting_disabled_for_viewer { get; set; }
        public int taken_at_timestamp { get; set; }
        public EdgeMediaPreviewLike edge_media_preview_like { get; set; }
        public EdgeMediaToSponsorUser edge_media_to_sponsor_user { get; set; }
        public Location location { get; set; }
        public bool viewer_has_liked { get; set; }
        public bool viewer_has_saved { get; set; }
        public bool viewer_has_saved_to_collection { get; set; }
        public bool viewer_in_photo_of_you { get; set; }
        public bool viewer_can_reshare { get; set; }
        public Owner owner { get; set; }
        public bool is_ad { get; set; }
        public EdgeWebMediaToRelatedMedia edge_web_media_to_related_media { get; set; }
    }
}