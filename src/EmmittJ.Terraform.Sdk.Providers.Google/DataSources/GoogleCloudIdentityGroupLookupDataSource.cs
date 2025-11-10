using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for group_key in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock : TerraformBlock
{
    /// <summary>
    /// The ID of the entity. For Google-managed entities, the id should be the email address of an existing group or user.
    /// For external-identity-mapped entities, the id must be a string conforming to the Identity Source&#39;s requirements.
    /// Must be unique within a namespace.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The namespace in which the entity exists. If not specified, the EntityKey represents a Google-managed entity such as a Google user or a Google Group.
    /// If specified, the EntityKey represents an external-identity-mapped group. The namespace must correspond to an identity source created in Admin Console and must be in the form of identitysources/{identity_source}.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => WithProperty("namespace", value);
    }

}

/// <summary>
/// Retrieves information about a google_cloud_identity_group_lookup.
/// </summary>
public class GoogleCloudIdentityGroupLookupDataSource : TerraformDataSource
{
    public GoogleCloudIdentityGroupLookupDataSource(string name) : base("google_cloud_identity_group_lookup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Block for group_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GroupKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupKey block(s) allowed")]
    public List<GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock>? GroupKey
    {
        get => GetProperty<List<GoogleCloudIdentityGroupLookupDataSourceGroupKeyBlock>>("group_key");
        set => this.WithProperty("group_key", value);
    }

    /// <summary>
    /// The [resource name](https://cloud.google.com/apis/design/resource_names) of the looked-up Group.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
