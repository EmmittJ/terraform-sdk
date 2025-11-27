using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_data_share_consumer_association Terraform resource.
/// Manages a aws_redshift_data_share_consumer_association resource.
/// </summary>
public partial class AwsRedshiftDataShareConsumerAssociation(string name) : TerraformResource("aws_redshift_data_share_consumer_association", name)
{
    /// <summary>
    /// The allow_writes attribute.
    /// </summary>
    public TerraformValue<bool>? AllowWrites
    {
        get => new TerraformReference<bool>(this, "allow_writes");
        set => SetArgument("allow_writes", value);
    }

    /// <summary>
    /// The associate_entire_account attribute.
    /// </summary>
    public TerraformValue<bool>? AssociateEntireAccount
    {
        get => new TerraformReference<bool>(this, "associate_entire_account");
        set => SetArgument("associate_entire_account", value);
    }

    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    public TerraformValue<string>? ConsumerArn
    {
        get => new TerraformReference<string>(this, "consumer_arn");
        set => SetArgument("consumer_arn", value);
    }

    /// <summary>
    /// The consumer_region attribute.
    /// </summary>
    public TerraformValue<string>? ConsumerRegion
    {
        get => new TerraformReference<string>(this, "consumer_region");
        set => SetArgument("consumer_region", value);
    }

    /// <summary>
    /// The data_share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareArn is required")]
    public required TerraformValue<string> DataShareArn
    {
        get => new TerraformReference<string>(this, "data_share_arn");
        set => SetArgument("data_share_arn", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The managed_by attribute.
    /// </summary>
    public TerraformValue<string> ManagedBy
    {
        get => new TerraformReference<string>(this, "managed_by");
    }

    /// <summary>
    /// The producer_arn attribute.
    /// </summary>
    public TerraformValue<string> ProducerArn
    {
        get => new TerraformReference<string>(this, "producer_arn");
    }

}
