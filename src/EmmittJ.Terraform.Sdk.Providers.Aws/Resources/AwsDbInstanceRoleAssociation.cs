using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbInstanceRoleAssociationTimeoutsBlock : TerraformBlock
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
/// Manages a aws_db_instance_role_association resource.
/// </summary>
public class AwsDbInstanceRoleAssociation : TerraformResource
{
    public AwsDbInstanceRoleAssociation(string name) : base("aws_db_instance_role_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbInstanceIdentifier is required")]
    public required TerraformProperty<string> DbInstanceIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("db_instance_identifier");
        set => this.WithProperty("db_instance_identifier", value);
    }

    /// <summary>
    /// The feature_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureName is required")]
    public required TerraformProperty<string> FeatureName
    {
        get => GetProperty<TerraformProperty<string>>("feature_name");
        set => this.WithProperty("feature_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbInstanceRoleAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDbInstanceRoleAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
