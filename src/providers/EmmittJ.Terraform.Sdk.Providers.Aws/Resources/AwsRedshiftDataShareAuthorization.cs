using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_data_share_authorization resource.
/// </summary>
public class AwsRedshiftDataShareAuthorization : TerraformResource
{
    public AwsRedshiftDataShareAuthorization(string name) : base("aws_redshift_data_share_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputd");
        this.WithOutputanaged_by");
        this.WithOutputroducer_arn");
    }

    /// <summary>
    /// The allow_writes attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowWrites
    {
        get => GetProperty<TerraformProperty<bool>>("allow_writes");
        set => this.WithProperty("allow_writes", value);
    }

    /// <summary>
    /// The consumer_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerIdentifier is required")]
    public required TerraformProperty<string> ConsumerIdentifier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("consumer_identifier");
        set => this.WithProperty("consumer_identifier", value);
    }

    /// <summary>
    /// The data_share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareArn is required")]
    public required TerraformProperty<string> DataShareArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_share_arn");
        set => this.WithProperty("data_share_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
