using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_data_share_authorization Terraform resource.
/// Manages a aws_redshift_data_share_authorization resource.
/// </summary>
public partial class AwsRedshiftDataShareAuthorization(string name) : TerraformResource("aws_redshift_data_share_authorization", name)
{
    /// <summary>
    /// The allow_writes attribute.
    /// </summary>
    public TerraformValue<bool>? AllowWrites
    {
        get => GetArgument<TerraformValue<bool>>("allow_writes");
        set => SetArgument("allow_writes", value);
    }

    /// <summary>
    /// The consumer_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerIdentifier is required")]
    public required TerraformValue<string> ConsumerIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("consumer_identifier");
        set => SetArgument("consumer_identifier", value);
    }

    /// <summary>
    /// The data_share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareArn is required")]
    public required TerraformValue<string> DataShareArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_share_arn");
        set => SetArgument("data_share_arn", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The managed_by attribute.
    /// </summary>
    public TerraformValue<string> ManagedBy
        => CreateReference("managed_by");

    /// <summary>
    /// The producer_arn attribute.
    /// </summary>
    public TerraformValue<string> ProducerArn
        => CreateReference("producer_arn");

}
