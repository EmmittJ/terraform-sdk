using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for group_key in GoogleCloudIdentityGroupLookupDataSource.
/// Nesting mode: list
/// </summary>
public class GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group_key";

    /// <summary>
    /// The ID of the entity. For Google-managed entities, the id should be the email address of an existing group or user.
    /// For external-identity-mapped entities, the id must be a string conforming to the Identity Source&#39;s requirements.
    /// Must be unique within a namespace.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The namespace in which the entity exists. If not specified, the EntityKey represents a Google-managed entity such as a Google user or a Google Group.
    /// If specified, the EntityKey represents an external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console and must be in the form of identitysources/{identity_source}.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

}


/// <summary>
/// Represents a google_cloud_identity_group_lookup Terraform data source.
/// Retrieves information about a google_cloud_identity_group_lookup.
/// </summary>
public partial class GoogleCloudIdentityGroupLookupDataSource(string name) : TerraformDataSource("google_cloud_identity_group_lookup", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The [resource name](https://cloud.google.com/apis/design/resource_names) of the looked-up Group.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// GroupKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GroupKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupKey block(s) allowed")]
    public required TerraformList<GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock> GroupKey
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock>>("group_key");
        set => SetArgument("group_key", value);
    }

}
