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
    public bool? CreateIgnoreAlreadyExists
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_ignore_already_exists")?.Value;
        set => this.WithProperty("create_ignore_already_exists", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name of the Group to create this membership in.
    /// </summary>
    public string? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group")?.Value;
        set => this.WithProperty("group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
