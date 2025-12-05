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
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The account attribute.
    /// </summary>
    public TerraformValue<string> Account
        => CreateReference("account");

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformValue<string> Partition
        => CreateReference("partition");

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
        => CreateReference("region");

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public TerraformValue<string> Resource
        => CreateReference("resource");

    /// <summary>
    /// The service attribute.
    /// </summary>
    public TerraformValue<string> Service
        => CreateReference("service");

}
