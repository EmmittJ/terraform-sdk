using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_timestreamwrite_database Terraform data source.
/// Retrieves information about a aws_timestreamwrite_database.
/// </summary>
public partial class AwsTimestreamwriteDatabaseDataSource(string name) : TerraformDataSource("aws_timestreamwrite_database", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
    {
        get => new TerraformReference<string>(this, "last_updated_time");
    }

    /// <summary>
    /// The table_count attribute.
    /// </summary>
    public TerraformValue<double> TableCount
    {
        get => new TerraformReference<double>(this, "table_count");
    }

}
