using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_arn Terraform data source.
/// Retrieves information about a aws_arn.
/// </summary>
public partial class AwsArnDataSource(string name) : TerraformDataSource("aws_arn", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
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
    /// The account attribute.
    /// </summary>
    public TerraformValue<string> Account
    {
        get => new TerraformReference<string>(this, "account");
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformValue<string> Partition
    {
        get => new TerraformReference<string>(this, "partition");
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
    }

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public TerraformValue<string> Resource
    {
        get => new TerraformReference<string>(this, "resource");
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
    }

}
