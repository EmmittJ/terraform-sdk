using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3tables_table_bucket Terraform resource.
/// Manages a aws_s3tables_table_bucket resource.
/// </summary>
public partial class AwsS3tablesTableBucket(string name) : TerraformResource("aws_s3tables_table_bucket", name)
{
    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformMap<object>? EncryptionConfiguration
    {
        get => GetArgument<TerraformMap<object>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool> ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy") ?? CreateReference("force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The maintenance_configuration attribute.
    /// </summary>
    public TerraformMap<object> MaintenanceConfiguration
    {
        get => GetArgument<TerraformMap<object>>("maintenance_configuration") ?? CreateReference("maintenance_configuration");
        set => SetArgument("maintenance_configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
        => CreateReference("owner_account_id");

}
