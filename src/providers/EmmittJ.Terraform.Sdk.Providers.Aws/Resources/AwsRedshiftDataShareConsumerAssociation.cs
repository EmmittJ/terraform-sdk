using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_data_share_consumer_association resource.
/// </summary>
public class AwsRedshiftDataShareConsumerAssociation : TerraformResource
{
    public AwsRedshiftDataShareConsumerAssociation(string name) : base("aws_redshift_data_share_consumer_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("managed_by");
        SetOutput("producer_arn");
        SetOutput("allow_writes");
        SetOutput("associate_entire_account");
        SetOutput("consumer_arn");
        SetOutput("consumer_region");
        SetOutput("data_share_arn");
        SetOutput("region");
    }

    /// <summary>
    /// The allow_writes attribute.
    /// </summary>
    public TerraformProperty<bool> AllowWrites
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_writes");
        set => SetProperty("allow_writes", value);
    }

    /// <summary>
    /// The associate_entire_account attribute.
    /// </summary>
    public TerraformProperty<bool> AssociateEntireAccount
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("associate_entire_account");
        set => SetProperty("associate_entire_account", value);
    }

    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    public TerraformProperty<string> ConsumerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("consumer_arn");
        set => SetProperty("consumer_arn", value);
    }

    /// <summary>
    /// The consumer_region attribute.
    /// </summary>
    public TerraformProperty<string> ConsumerRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("consumer_region");
        set => SetProperty("consumer_region", value);
    }

    /// <summary>
    /// The data_share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareArn is required")]
    public required TerraformProperty<string> DataShareArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_share_arn");
        set => SetProperty("data_share_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The managed_by attribute.
    /// </summary>
    public TerraformExpression ManagedBy => this["managed_by"];

    /// <summary>
    /// The producer_arn attribute.
    /// </summary>
    public TerraformExpression ProducerArn => this["producer_arn"];

}
