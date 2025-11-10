using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_contact_channel.
/// </summary>
public class AwsSsmcontactsContactChannelDataSource : TerraformDataSource
{
    public AwsSsmcontactsContactChannelDataSource(string name) : base("aws_ssmcontacts_contact_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("activation_status");
        SetOutput("contact_id");
        SetOutput("delivery_address");
        SetOutput("name");
        SetOutput("type");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The activation_status attribute.
    /// </summary>
    public TerraformExpression ActivationStatus => this["activation_status"];

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    public TerraformExpression ContactId => this["contact_id"];

    /// <summary>
    /// The delivery_address attribute.
    /// </summary>
    public TerraformExpression DeliveryAddress => this["delivery_address"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
