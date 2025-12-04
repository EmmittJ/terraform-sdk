using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshiftserverless_credentials Terraform data source.
/// Retrieves information about a aws_redshiftserverless_credentials.
/// </summary>
public partial class AwsRedshiftserverlessCredentialsDataSource(string name) : TerraformDataSource("aws_redshiftserverless_credentials", name)
{
    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string>? DbName
    {
        get => GetArgument<TerraformValue<string>>("db_name");
        set => SetArgument("db_name", value);
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DurationSeconds
    {
        get => GetArgument<TerraformValue<double>>("duration_seconds");
        set => SetArgument("duration_seconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformValue<string> WorkgroupName
    {
        get => GetArgument<TerraformValue<string>>("workgroup_name");
        set => SetArgument("workgroup_name", value);
    }

    /// <summary>
    /// The db_password attribute.
    /// </summary>
    public TerraformValue<string> DbPassword
        => AsReference("db_password");

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformValue<string> DbUser
        => AsReference("db_user");

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformValue<string> Expiration
        => AsReference("expiration");

}
