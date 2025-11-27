using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssmcontacts_contact_channel Terraform data source.
/// Retrieves information about a aws_ssmcontacts_contact_channel.
/// </summary>
public partial class AwsSsmcontactsContactChannelDataSource(string name) : TerraformDataSource("aws_ssmcontacts_contact_channel", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The activation_status attribute.
    /// </summary>
    public TerraformValue<string> ActivationStatus
    {
        get => new TerraformReference<string>(this, "activation_status");
    }

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    public TerraformValue<string> ContactId
    {
        get => new TerraformReference<string>(this, "contact_id");
    }

    /// <summary>
    /// The delivery_address attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeliveryAddress
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "delivery_address").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
