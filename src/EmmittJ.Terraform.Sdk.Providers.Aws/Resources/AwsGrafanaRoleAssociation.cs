using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGrafanaRoleAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_grafana_role_association resource.
/// </summary>
public class AwsGrafanaRoleAssociation : TerraformResource
{
    public AwsGrafanaRoleAssociation(string name) : base("aws_grafana_role_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? GroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("group_ids");
        set => this.WithProperty("group_ids", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The user_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? UserIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("user_ids");
        set => this.WithProperty("user_ids", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGrafanaRoleAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsGrafanaRoleAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
