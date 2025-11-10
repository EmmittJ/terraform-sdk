using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_address in .
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsContactChannelDeliveryAddressBlock : TerraformBlock
{
    /// <summary>
    /// The simple_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SimpleAddress is required")]
    public required TerraformProperty<string> SimpleAddress
    {
        get => GetProperty<TerraformProperty<string>>("simple_address");
        set => WithProperty("simple_address", value);
    }

}

/// <summary>
/// Manages a aws_ssmcontacts_contact_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmcontactsContactChannel : TerraformResource
{
    public AwsSsmcontactsContactChannel(string name) : base("aws_ssmcontacts_contact_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("activation_status");
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactId is required")]
    public required TerraformProperty<string> ContactId
    {
        get => GetProperty<TerraformProperty<string>>("contact_id");
        set => this.WithProperty("contact_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for delivery_address.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DeliveryAddress block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryAddress block(s) allowed")]
    public List<AwsSsmcontactsContactChannelDeliveryAddressBlock>? DeliveryAddress
    {
        get => GetProperty<List<AwsSsmcontactsContactChannelDeliveryAddressBlock>>("delivery_address");
        set => this.WithProperty("delivery_address", value);
    }

    /// <summary>
    /// The activation_status attribute.
    /// </summary>
    public TerraformExpression ActivationStatus => this["activation_status"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
