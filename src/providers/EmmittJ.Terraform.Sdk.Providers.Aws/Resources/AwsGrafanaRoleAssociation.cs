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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("group_ids");
        SetOutput("id");
        SetOutput("region");
        SetOutput("role");
        SetOutput("user_ids");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> GroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("group_ids");
        set => SetProperty("group_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role");
        set => SetProperty("role", value);
    }

    /// <summary>
    /// The user_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> UserIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("user_ids");
        set => SetProperty("user_ids", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGrafanaRoleAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
