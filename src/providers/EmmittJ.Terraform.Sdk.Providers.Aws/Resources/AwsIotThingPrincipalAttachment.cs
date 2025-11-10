using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing_principal_attachment resource.
/// </summary>
public class AwsIotThingPrincipalAttachment : TerraformResource
{
    public AwsIotThingPrincipalAttachment(string name) : base("aws_iot_thing_principal_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("principal");
        SetOutput("region");
        SetOutput("thing");
        SetOutput("thing_principal_type");
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
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal");
        set => SetProperty("principal", value);
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
    /// The thing attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Thing is required")]
    public required TerraformProperty<string> Thing
    {
        get => GetRequiredOutput<TerraformProperty<string>>("thing");
        set => SetProperty("thing", value);
    }

    /// <summary>
    /// The thing_principal_type attribute.
    /// </summary>
    public TerraformProperty<string> ThingPrincipalType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("thing_principal_type");
        set => SetProperty("thing_principal_type", value);
    }

}
