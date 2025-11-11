using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelDataSourceFiltersBlock
{


}

/// <summary>
/// Block type for sns in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruNotificationChannelDataSourceSnsBlock
{

}

/// <summary>
/// Retrieves information about a aws_devopsguru_notification_channel.
/// </summary>
public class AwsDevopsguruNotificationChannelDataSource : TerraformDataSource
{
    public AwsDevopsguruNotificationChannelDataSource(string name) : base("aws_devopsguru_notification_channel", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("filters")]
    public TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelDataSourceFiltersBlock>>? Filters { get; set; }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("sns")]
    public TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelDataSourceSnsBlock>>? Sns { get; set; }

}
