using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_destination in .
/// Nesting mode: list
/// </summary>
public class AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The matching_event_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingEventTypes is required")]
    public HashSet<TerraformProperty<string>>? MatchingEventTypes
    {
        set => SetProperty("matching_event_types", value);
    }

}

/// <summary>
/// Manages a aws_sesv2_configuration_set_event_destination resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSesv2ConfigurationSetEventDestination : TerraformResource
{
    public AwsSesv2ConfigurationSetEventDestination(string name) : base("aws_sesv2_configuration_set_event_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("configuration_set_name");
        SetOutput("event_destination_name");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    public required TerraformProperty<string> ConfigurationSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_set_name");
        set => SetProperty("configuration_set_name", value);
    }

    /// <summary>
    /// The event_destination_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventDestinationName is required")]
    public required TerraformProperty<string> EventDestinationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("event_destination_name");
        set => SetProperty("event_destination_name", value);
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
    /// Block for event_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventDestination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EventDestination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventDestination block(s) allowed")]
    public List<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock>? EventDestination
    {
        set => SetProperty("event_destination", value);
    }

}
