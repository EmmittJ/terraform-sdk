using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruNotificationChannelDataSourceFiltersBlock : TerraformBlockBase
{


}

/// <summary>
/// Block type for sns in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruNotificationChannelDataSourceSnsBlock : TerraformBlockBase
{

}

/// <summary>
/// Retrieves information about a aws_devopsguru_notification_channel.
/// </summary>
public partial class AwsDevopsguruNotificationChannelDataSource : TerraformDataSource
{
    public AwsDevopsguruNotificationChannelDataSource(string name) : base("aws_devopsguru_notification_channel", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("filters")]
    public TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelDataSourceFiltersBlock>>? Filters { get; set; }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("sns")]
    public TerraformList<TerraformBlock<AwsDevopsguruNotificationChannelDataSourceSnsBlock>>? Sns { get; set; }

}
