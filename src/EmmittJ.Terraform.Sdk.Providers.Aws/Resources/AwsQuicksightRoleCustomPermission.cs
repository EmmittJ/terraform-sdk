using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_role_custom_permission resource.
/// </summary>
public class AwsQuicksightRoleCustomPermission : TerraformResource
{
    public AwsQuicksightRoleCustomPermission(string name) : base("aws_quicksight_role_custom_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
    }

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomPermissionsName is required")]
    public required TerraformProperty<string> CustomPermissionsName
    {
        get => GetProperty<TerraformProperty<string>>("custom_permissions_name");
        set => this.WithProperty("custom_permissions_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
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

}
