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
        get => new TerraformReference<string>(this, "db_name");
        set => SetArgument("db_name", value);
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DurationSeconds
    {
        get => new TerraformReference<double>(this, "duration_seconds");
        set => SetArgument("duration_seconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformValue<string> WorkgroupName
    {
        get => new TerraformReference<string>(this, "workgroup_name");
        set => SetArgument("workgroup_name", value);
    }

    /// <summary>
    /// The db_password attribute.
    /// </summary>
    public TerraformValue<string> DbPassword
    {
        get => new TerraformReference<string>(this, "db_password");
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformValue<string> DbUser
    {
        get => new TerraformReference<string>(this, "db_user");
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformValue<string> Expiration
    {
        get => new TerraformReference<string>(this, "expiration");
    }

}
