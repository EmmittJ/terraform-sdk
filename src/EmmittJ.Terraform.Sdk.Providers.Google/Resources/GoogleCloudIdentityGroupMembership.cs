using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_cloud_identity_group_membership resource.
/// </summary>
public class GoogleCloudIdentityGroupMembership : TerraformResource
{
    public GoogleCloudIdentityGroupMembership(string name) : base("google_cloud_identity_group_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("type");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// If set to true, skip group member creation if a membership with the same name already exists. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? CreateIgnoreAlreadyExists
    {
        get => GetProperty<TerraformProperty<bool>>("create_ignore_already_exists");
        set => this.WithProperty("create_ignore_already_exists", value);
    }

    /// <summary>
    /// The name of the Group to create this membership in.
    /// </summary>
    public TerraformProperty<string>? Group
    {
        get => GetProperty<TerraformProperty<string>>("group");
        set => this.WithProperty("group", value);
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
    /// The time when the Membership was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The resource name of the Membership, of the form groups/{group_id}/memberships/{membership_id}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The type of the membership.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The time when the Membership was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
