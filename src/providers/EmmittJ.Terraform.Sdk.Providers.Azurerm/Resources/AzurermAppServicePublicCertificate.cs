using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServicePublicCertificate.
/// Nesting mode: single
/// </summary>
public class AzurermAppServicePublicCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_app_service_public_certificate Terraform resource.
/// Manages a azurerm_app_service_public_certificate resource.
/// </summary>
public partial class AzurermAppServicePublicCertificate(string name) : TerraformResource("azurerm_app_service_public_certificate", name)
{
    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    public required TerraformValue<string> AppServiceName
    {
        get => GetArgument<TerraformValue<string>>("app_service_name");
        set => SetArgument("app_service_name", value);
    }

    /// <summary>
    /// The blob attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Blob is required")]
    public required TerraformValue<string> Blob
    {
        get => GetArgument<TerraformValue<string>>("blob");
        set => SetArgument("blob", value);
    }

    /// <summary>
    /// The certificate_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateLocation is required")]
    public required TerraformValue<string> CertificateLocation
    {
        get => GetArgument<TerraformValue<string>>("certificate_location");
        set => SetArgument("certificate_location", value);
    }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateName is required")]
    public required TerraformValue<string> CertificateName
    {
        get => GetArgument<TerraformValue<string>>("certificate_name");
        set => SetArgument("certificate_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServicePublicCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServicePublicCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
