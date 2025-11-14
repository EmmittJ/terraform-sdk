#pragma warning disable ASPIREPIPELINES001

using System.Diagnostics.CodeAnalysis;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Defines well-known pipeline tags for Terraform code generation steps.
/// </summary>
[Experimental("ASPIREPIPELINES001", UrlFormat = "https://aka.ms/aspire/diagnostics/{0}")]
public static class TerraformCodeGenPipelineTags
{
    /// <summary>
    /// Tag for steps that generate Terraform provider schemas.
    /// </summary>
    public const string GenerateSchema = "terraform-generate-schema";

    /// <summary>
    /// Tag for steps that parse Terraform provider schemas.
    /// </summary>
    public const string ParseSchema = "terraform-parse-schema";

    /// <summary>
    /// Tag for steps that generate provider code from schemas.
    /// </summary>
    public const string GenerateCode = "terraform-generate-code";
}
